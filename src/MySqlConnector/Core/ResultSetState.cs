namespace MySqlConnector.Core
{
	public enum ResultSetState
	{
		None,
		ReadResultSetHeader,
		ReadingRows,
		HasMoreData,
		NoMoreData,
	}
}
