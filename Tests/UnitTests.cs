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
		Assert.AreEqual(1, Program.Subtract("2", "1"));
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(1, Program.Subtract("5", "4"));
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
		Assert.AreEqual(2, Program.Multiply("1", "2"));
		Assert.AreEqual(6, Program.Multiply("3", "2"));
		Assert.AreEqual(35, Program.Multiply("5", "7"));
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
		Assert.AreEqual(2, Program.Divide("2", "1"));
		Assert.AreEqual(3, Program.Divide("6", "2"));
		Assert.AreEqual(5, Program.Divide("35", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
	}
}
//power
public class Power
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(1, Program.Power("1", "2"));
		Assert.AreEqual(9, Program.Power("3", "2"));
		Assert.AreEqual(25, Program.Power("5", "2"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
	}
}