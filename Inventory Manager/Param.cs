using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Manager
{
    class Param
    {
        private string parameterName;
        private object parameterData;
        private Type parameterType;

        public string Key
        {
            get { return parameterName; }
            set { parameterName = value; }
        }

        public object Value
        {
            get { return parameterData; }
            set { parameterData = value; }
        }

        public Type SystemType
        {
            get { return parameterType; }
            set { parameterType = value; }
        }

        public SqlParameter SQLParam
        {
            get
            {
                //if (Value == null)
                //{
                //    throw new ArgumentException("A value must be given.", "Value");
                //}

                //if (SystemType == null)
                //{
                //    throw new ArgumentException("A parameter type must be specified.", "SystemType");
                //}

                SqlParameter param = new SqlParameter();

                param.ParameterName = Key;

                if (SystemType == typeof(string))
                {
                    param.Value = (string)Value;
                    param.SqlDbType = SqlDbType.VarChar;
                }
                else if (SystemType == typeof(int))
                {
                    param.Value = (int)Value;
                    param.SqlDbType = SqlDbType.Int;
                }
                else if (SystemType == typeof(double))
                {
                    param.Value = (double)Value;
                    param.SqlDbType = SqlDbType.Float;
                }
                else if (SystemType == typeof(bool))
                {
                    param.Value = (bool)Value;
                    param.SqlDbType = SqlDbType.Bit;
                }
                else if (SystemType == typeof(DateTime))
                {
                    param.Value = (DateTime)Value;
                    param.SqlDbType = SqlDbType.DateTime;
                }
                else if (Value == null)
                {
                    param.Value = null;
                }
                else
                {
                    //param.Value = DBNull.Value;
                    throw new ArgumentException("Not a recognized SQL parameter type.", "SystemType");
                }

                return param;
            }
        }

        public Param(string paramName = "", object paramData = null, Type paramType = null)
        {
            if (paramName != "")
            {
                if (paramName[0] != '@')
                {
                    paramName = "@" + paramName;
                }
            }

            Key = paramName;
            Value = paramData;
            SystemType = paramType;
        }

        public Param(string paramName, bool isNull)
        {
            if (paramName != "")
            {
                if (paramName[0] != '@')
                {
                    paramName = "@" + paramName;
                }
            }

            Key = paramName;
            if (isNull)
            {
                Value = null;
            }
        }
    }

}
