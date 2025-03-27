namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}
// sub
public class Subtract
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Subtract("1", "2"));
		Assert.AreEqual(5, Program.Subtract("3", "2"));
		Assert.AreEqual(12, Program.Subtract("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
	}
}
// mult
public class Multiply
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Multiply("1", "2"));
		Assert.AreEqual(5, Program.Multiply("3", "2"));
		Assert.AreEqual(12, Program.Multiply("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
	}
}
// div
public class Divide
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Multiply("1", "2"));
		Assert.AreEqual(5, Program.Multiply("3", "2"));
		Assert.AreEqual(12, Program.Multiply("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
	}
}
