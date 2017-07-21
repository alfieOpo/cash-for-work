using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace DataLayer
{
    public class Access
    {
        private SqlConnection _con;
        private DataTable _table;
        private int _rows_affected;
        public long _insert_id;
        private string _error;
        private SqlCommand _cmd_builder;
        private string _sql_builder;
        private SqlTransaction _transaction;
        private bool _use_transaction = false;

        public Access()
        {
            this.connect();
        }

        public bool connect()
        {
            try
            {
                this._con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
                this._con.Open();
                return true;
            }
            catch (Exception ex)
            {
                this._error = ex.Message;
                return false;
            }
        }

        public long InsertedID
        {
            get { return this._insert_id; }
        }

        public bool Connected()
        {
            if (this._con != null && this._con.State != ConnectionState.Open)
            {
                this._error = "Connection cannot be established. Please contact your system administrator";
                return false;
            }
            return true;
        }

        public string Error
        {
            get { return this._error; }
        }

        public DataTable getTable()
        {
            return this._table;
        }

        public void createCommand(string _sql)
        {
            this._sql_builder = _sql;
            this._cmd_builder = new SqlCommand(_sql);
        }

        public void addParameter(string field, string value)
        {
            this._cmd_builder.Parameters.Add(new SqlParameter(field, value));
        }

        public void addParameter(string field, byte[] value)
        {
            this._cmd_builder.Parameters.Add(field, SqlDbType.VarBinary, value.Length).Value = value;
        }

        public void addParameter(string field, int value)
        {
            this._cmd_builder.Parameters.Add(new SqlParameter(field, value));
        }

        public void addParameter(string field, decimal value)
        {
            this._cmd_builder.Parameters.Add(new SqlParameter(field, value));
        }

        public void addParameter(string field, float value)
        {
            this._cmd_builder.Parameters.Add(new SqlParameter(field, value));
        }

        public void addParameter(string field, DateTime value)
        {
            this._cmd_builder.Parameters.Add(new SqlParameter(field, value));
        }

        public void addOutputParameter(string field)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = field;
            param.Size = 255;
            param.Direction = ParameterDirection.Output;
            this._cmd_builder.Parameters.Add(param);
        }

        public List<System.Collections.Generic.KeyValuePair<string, string>> getOutputParameter()
        {
            List<System.Collections.Generic.KeyValuePair<string, string>> retval = new List<System.Collections.Generic.KeyValuePair<string, string>>();
            foreach (SqlParameter par in this._cmd_builder.Parameters)
            {
                if (par.Direction == ParameterDirection.Output)
                {
                    retval.Add(new System.Collections.Generic.KeyValuePair<string, string>(par.ParameterName, par.Value.ToString()));
                }
                if (par.Direction == ParameterDirection.InputOutput)
                {
                    retval.Add(new System.Collections.Generic.KeyValuePair<string, string>(par.ParameterName, par.Value.ToString()));
                }
            }
            return retval;
        }

        public string getOutputParameterValue(string name)
        {
            foreach (SqlParameter par in this._cmd_builder.Parameters)
            {
                if (par.ParameterName == name)
                {
                    return par.Value.ToString();
                }
            }
            return "";
        }

        public bool fillCommand()
        {
            try
            {
                if (!this.Connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }

                this._table = new DataTable();
                this._cmd_builder.Connection = this._con;
                SqlDataAdapter da = new SqlDataAdapter(this._cmd_builder);
                da.Fill(this._table);
                if (this._table.Rows.Count.Equals(0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                this._error = ex.Message;
                return false;
            }
        }

        public void useStoreProcedure()
        {
            this._cmd_builder.CommandType = CommandType.StoredProcedure;
        }

        public bool executeCommand()
        {
            try
            {
                if (!this.Connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }

                this._cmd_builder.Connection = this._con;
                if (this._cmd_builder.CommandText.Substring(0, 3).Equals("sp_"))
                {
                    this._cmd_builder.CommandType = CommandType.StoredProcedure;
                }
                if (this._use_transaction)
                {
                    this._cmd_builder.Transaction = _transaction;
                }
                this._rows_affected = this._cmd_builder.ExecuteNonQuery();
                //if (this._rows_affected == 0)
                //{
                //    this._error = "Error on database execution. Please contact your system administrator.";
                //    return false;
                //}

                this._insert_id = 0;
                return true;
            }
            catch (Exception ex)
            {
                this._error = ex.Message;
                return false;
            }
        }

        public DataRow executeScalar(string sql)
        {
            try
            {
                if (!this.Connected())
                {
                    if (!this.connect())
                    {
                        return null;
                    }
                }

                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = this._con;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                else
                {
                    this._error = "No Record Found";
                    return null;
                }
            }
            catch (Exception ex)
            {
                this._error = ex.Message;
                return null;
            }
        }

        public void beginTransaction()
        {
            this._use_transaction = true;
            this._transaction = this._con.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void rollbackTransaction()
        {
            this._transaction.Rollback();
            this._use_transaction = false;
            this._transaction = null;
        }

        public void commitTransaction()
        {
            this._transaction.Commit();
            this._use_transaction = false;
            this._transaction = null;
        }

        public bool query(string query)
        {
            try
            {
                if (!this.Connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }

                SqlCommand cmd = new SqlCommand(query, this._con);

                this._table = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(this._table);
                if (this._table.Rows.Count.Equals(0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                this._error = ex.Message;
                return false;
            }
        }

        public bool insert(string sql)
        {
            try
            {
                if (!this.Connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }

                SqlCommand cmd = new SqlCommand(sql, this._con);

                this._rows_affected = cmd.ExecuteNonQuery();
                if (this._rows_affected == 0)
                {
                    this._error = "No record was inserted. Please contact your system administrator.";
                    return false;
                }
                //this.insert_id = cmd.LastInsertedId;
                return true;
            }
            catch (Exception ex)
            {
                this._error = ex.Message;
                return false;
            }
        }

        public bool update(string sql)
        {
            try
            {
                if (!this.Connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }

                SqlCommand cmd = new SqlCommand(sql, this._con);

                this._rows_affected = cmd.ExecuteNonQuery();
                if (this._rows_affected == 0)
                {
                    this._error = "No record was updated. Please contact your system administrator.";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                this._error = ex.Message;
                return false;
            }
        }

        public bool delete(string sql)
        {

            try
            {
                if (!this.Connected())
                {
                    if (!this.connect())
                    {
                        return false;
                    }
                }

                SqlCommand cmd = new SqlCommand(sql, this._con);

                this._rows_affected = cmd.ExecuteNonQuery();
                if (this._rows_affected == 0)
                {
                    this._error = "No record was deleted. Please contact your system administrator.";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                this._error = ex.Message;
                return false;
            }

        }

       

        public string md5(string input)
        {
            // step 1, calculate MD5 hash from input
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}

