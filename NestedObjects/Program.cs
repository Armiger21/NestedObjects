
using NestedObjects;
using System.ComponentModel.DataAnnotations;

Advisor compSciAdvisor = new Advisor()
{
	Email = "Annaemarie@cptc.edu",
	FullName = "Annemarie Smith",
	OfficeLocation = "B17 Rm 150"
};

Students stu1 = new Students()
{
	FirstName = "Homer",
	LastName = "Simpson",
	DateOfBirth = new DateOnly(2000, 3,20),
	AssignedAdvisor = compSciAdvisor,
	PhoneNumber = "2535894534",
	SchoolEmail = "Himer.Simpson@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");