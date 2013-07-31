using System;
using System.Data;
using System.Data.SqlClient;

public class FactoryUtils {

	private FactoryUtils() {
	}

	public static Object GetValueFromRs(IDataReader r, String columnName) {
		Object val = null;
		try {
			
			val = r[columnName];
			if ("".Equals(val))
			{
				val = null;
			}
		}
			
		catch (SqlException sqle) {
			val = null;
		}
		return val;
	}

	public static long GetLongValueFromRs(IDataReader r, String columnName)
	{
	    long val = 0;
		try {
			if (r.GetString(r.GetOrdinal(columnName)) != null) {
				val = r.GetInt64(r.GetOrdinal(columnName));
			}
		}
		catch (SqlException sqle) {
		}
		return val;
	}

	public static byte GetByteValueFromRs(IDataReader r, String columnName) {
		byte val = 0;
		try {
			if (r.GetString(r.GetOrdinal(columnName)) != null) {
				val = r.GetByte(r.GetOrdinal(columnName));
			}
		}
		catch (SqlException sqle) {
			
		}
		return val;
	}

}
