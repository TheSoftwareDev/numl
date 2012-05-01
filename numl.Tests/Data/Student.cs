﻿/*
 Copyright (c) 2012 Seth Juarez

 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.
*/

using System;
using numl.Attributes;

namespace numl.Data
{
	public enum Grade
	{
		A,
		B,
		C,
		D,
		F
	}

	public class Student
	{
		public string Name { get; set; }
        [Feature]
		public Grade Grade { get; set; }
        [Feature]
		public double GPA { get; set; }
        [Feature]
		public int Age { get; set; }
		public bool Tall { get; set; }
        [Feature]
		public int Friends { get; set; }
        [Label]
		public bool Nice { get; set; }

		public static Student[] GetData()
		{
			return new Student[]
			{
				new Student { Name = "Aidan", Age = 27, Friends = 3, GPA = 0.54, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "2A!@m3el3ia", Age = 40, Friends = 7, GPA = 2.60, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Noah", Age = 26, Friends = 0, GPA = 2.39, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Isabella", Age = 21, Friends = 9, GPA = 3.83, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Liam", Age = 19, Friends = 3, GPA = 1.06, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Ava", Age = 16, Friends = 7, GPA = 3.31, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Cayden", Age = 34, Friends = 2, GPA = 1.01, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Sophia", Age = 28, Friends = 13, GPA = 3.33, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Ethan", Age = 21, Friends = 3, GPA = 0.33, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Olivia", Age = 32, Friends = 5, GPA = 3.12, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Jackson", Age = 26, Friends = 0, GPA = 0.47, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Madeline", Age = 40, Friends = 6, GPA = 3.63, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Landon", Age = 24, Friends = 1, GPA = 0.40, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Lily", Age = 26, Friends = 14, GPA = 3.40, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Jacob", Age = 20, Friends = 3, GPA = 1.02, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Abigail", Age = 32, Friends = 6, GPA = 3.10, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Caleb", Age = 37, Friends = 3, GPA = 1.52, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Chloe", Age = 32, Friends = 10, GPA = 3.59, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Lucas", Age = 28, Friends = 2, GPA = 1.66, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Emma", Age = 25, Friends = 13, GPA = 3.30, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Braden", Age = 27, Friends = 2, GPA = 2.09, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Charlotte", Age = 31, Friends = 10, GPA = 3.22, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Benjamin", Age = 26, Friends = 3, GPA = 0.69, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Ella", Age = 38, Friends = 12, GPA = 3.78, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Gavin", Age = 18, Friends = 3, GPA = 1.63, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Addison", Age = 27, Friends = 8, GPA = 3.65, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Connor", Age = 16, Friends = 0, GPA = 1.67, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Elizabeth", Age = 30, Friends = 10, GPA = 2.67, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Elijah", Age = 27, Friends = 1, GPA = 0.68, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Grace", Age = 27, Friends = 7, GPA = 2.54, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Oliver", Age = 24, Friends = 3, GPA = 1.66, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Audrey", Age = 26, Friends = 11, GPA = 3.86, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Alexander", Age = 38, Friends = 2, GPA = 0.17, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Emily", Age = 23, Friends = 13, GPA = 3.83, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Owen", Age = 39, Friends = 2, GPA = 0.73, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Bella", Age = 38, Friends = 12, GPA = 2.90, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Gabriel", Age = 36, Friends = 2, GPA = 2.17, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Hannah", Age = 35, Friends = 12, GPA = 3.11, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Logan", Age = 33, Friends = 2, GPA = 1.44, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Isabelle", Age = 23, Friends = 9, GPA = 3.13, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "William", Age = 40, Friends = 1, GPA = 0.93, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Scarlett", Age = 26, Friends = 14, GPA = 2.84, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Tristan", Age = 37, Friends = 3, GPA = 2.44, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Lila", Age = 32, Friends = 14, GPA = 3.05, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Jayden", Age = 19, Friends = 3, GPA = 1.38, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Arianna", Age = 31, Friends = 12, GPA = 3.31, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Cole", Age = 26, Friends = 0, GPA = 2.21, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Caitlyn", Age = 36, Friends = 7, GPA = 3.08, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Asher", Age = 16, Friends = 2, GPA = 2.16, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Kaylee", Age = 39, Friends = 7, GPA = 3.96, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Jack", Age = 19, Friends = 0, GPA = 1.04, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Keira", Age = 17, Friends = 10, GPA = 2.67, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "James", Age = 33, Friends = 1, GPA = 0.74, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Claire", Age = 22, Friends = 12, GPA = 2.97, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Chase", Age = 28, Friends = 2, GPA = 1.59, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Leah", Age = 39, Friends = 6, GPA = 2.99, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Nathan", Age = 20, Friends = 3, GPA = 1.50, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Layla", Age = 33, Friends = 12, GPA = 3.53, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Andrew", Age = 23, Friends = 0, GPA = 0.38, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Avery", Age = 27, Friends = 5, GPA = 3.51, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Elliot", Age = 36, Friends = 2, GPA = 0.44, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Madison", Age = 39, Friends = 10, GPA = 2.65, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Aaron", Age = 22, Friends = 3, GPA = 1.31, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Natalie", Age = 16, Friends = 13, GPA = 3.50, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Colin", Age = 26, Friends = 3, GPA = 0.14, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Sophie", Age = 34, Friends = 6, GPA = 3.91, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Grayson", Age = 20, Friends = 0, GPA = 1.70, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Payton", Age = 29, Friends = 7, GPA = 3.45, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Mason", Age = 40, Friends = 1, GPA = 0.08, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Hayley", Age = 26, Friends = 13, GPA = 3.83, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Nicholas", Age = 25, Friends = 2, GPA = 2.35, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Violet", Age = 28, Friends = 9, GPA = 3.03, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Joshua", Age = 25, Friends = 0, GPA = 0.85, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Sadie", Age = 24, Friends = 14, GPA = 2.87, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Dylan", Age = 20, Friends = 0, GPA = 1.25, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Lucy", Age = 37, Friends = 7, GPA = 3.33, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Isaac", Age = 37, Friends = 1, GPA = 0.18, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Nora", Age = 19, Friends = 9, GPA = 2.81, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Matthew", Age = 32, Friends = 3, GPA = 2.48, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Alice", Age = 21, Friends = 14, GPA = 3.71, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Levi", Age = 37, Friends = 0, GPA = 0.23, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Cailyn", Age = 35, Friends = 9, GPA = 2.53, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Jasper", Age = 23, Friends = 0, GPA = 1.39, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Savannah", Age = 39, Friends = 10, GPA = 3.06, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Zachary", Age = 24, Friends = 3, GPA = 1.14, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Adrianna", Age = 26, Friends = 13, GPA = 3.11, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Carter", Age = 34, Friends = 3, GPA = 2.22, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Anna", Age = 34, Friends = 14, GPA = 3.94, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Nathaniel", Age = 39, Friends = 0, GPA = 0.19, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Riley", Age = 29, Friends = 5, GPA = 3.32, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Evan", Age = 30, Friends = 1, GPA = 0.81, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Annabelle", Age = 22, Friends = 14, GPA = 3.42, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Sebastian", Age = 25, Friends = 2, GPA = 2.31, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Callie", Age = 30, Friends = 14, GPA = 3.69, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Dominic", Age = 18, Friends = 0, GPA = 0.53, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Paige", Age = 35, Friends = 10, GPA = 3.34, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Wyatt", Age = 20, Friends = 2, GPA = 1.73, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Alexis", Age = 24, Friends = 11, GPA = 2.82, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Henry", Age = 38, Friends = 1, GPA = 0.84, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Mia", Age = 32, Friends = 7, GPA = 3.70, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Ryan", Age = 19, Friends = 3, GPA = 0.03, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Evelyn", Age = 20, Friends = 5, GPA = 2.54, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Michael", Age = 34, Friends = 2, GPA = 1.88, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Kylie", Age = 28, Friends = 6, GPA = 3.09, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Luke", Age = 18, Friends = 0, GPA = 0.72, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Maya", Age = 36, Friends = 10, GPA = 2.55, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Emmett", Age = 26, Friends = 1, GPA = 1.65, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Aurora", Age = 18, Friends = 12, GPA = 3.79, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Ian", Age = 16, Friends = 1, GPA = 2.24, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Zoe", Age = 21, Friends = 13, GPA = 3.92, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Micah", Age = 28, Friends = 3, GPA = 2.48, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Alyssa", Age = 27, Friends = 5, GPA = 3.96, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Finn", Age = 19, Friends = 1, GPA = 0.19, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Juliet", Age = 21, Friends = 7, GPA = 3.30, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Samuel", Age = 23, Friends = 3, GPA = 1.00, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Eva", Age = 36, Friends = 13, GPA = 3.17, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Adam", Age = 40, Friends = 2, GPA = 2.31, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Michaela", Age = 28, Friends = 6, GPA = 3.85, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Xander", Age = 24, Friends = 1, GPA = 2.40, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Vivienne", Age = 40, Friends = 8, GPA = 3.14, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Daniel", Age = 37, Friends = 2, GPA = 2.37, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Ashlyn", Age = 33, Friends = 6, GPA = 4.01, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Seth", Age = 27, Friends = 0, GPA = 1.44, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Gabriella", Age = 21, Friends = 12, GPA = 3.12, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Parker", Age = 20, Friends = 3, GPA = 1.44, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Allison", Age = 21, Friends = 11, GPA = 2.69, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Ryder", Age = 38, Friends = 1, GPA = 0.57, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Cadence", Age = 38, Friends = 5, GPA = 2.71, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Edward", Age = 25, Friends = 0, GPA = 2.29, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Lillian", Age = 39, Friends = 5, GPA = 3.65, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Xavier", Age = 28, Friends = 2, GPA = 0.89, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Stella", Age = 16, Friends = 9, GPA = 3.57, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Max", Age = 35, Friends = 3, GPA = 0.61, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Sarah", Age = 29, Friends = 7, GPA = 3.41, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Damien", Age = 28, Friends = 1, GPA = 0.69, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Caroline", Age = 28, Friends = 6, GPA = 2.77, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Jonah", Age = 18, Friends = 3, GPA = 0.93, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Sienna", Age = 19, Friends = 11, GPA = 2.52, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Miles", Age = 21, Friends = 2, GPA = 0.38, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Lauren", Age = 26, Friends = 11, GPA = 3.29, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Adrian", Age = 17, Friends = 0, GPA = 1.70, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Aubrey", Age = 31, Friends = 11, GPA = 3.47, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Tyler", Age = 26, Friends = 0, GPA = 2.09, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Autumn", Age = 24, Friends = 6, GPA = 3.31, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Christopher", Age = 25, Friends = 2, GPA = 1.68, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Aaliyah", Age = 33, Friends = 6, GPA = 3.81, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Isaiah", Age = 37, Friends = 3, GPA = 2.37, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Victoria", Age = 28, Friends = 9, GPA = 3.98, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Carson", Age = 32, Friends = 0, GPA = 1.62, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Ruby", Age = 34, Friends = 8, GPA = 3.13, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Eli", Age = 40, Friends = 2, GPA = 0.32, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Catherine", Age = 36, Friends = 10, GPA = 2.51, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Thomas", Age = 21, Friends = 1, GPA = 0.82, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Alexandra", Age = 23, Friends = 11, GPA = 2.87, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Holden", Age = 17, Friends = 3, GPA = 1.66, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Samantha", Age = 26, Friends = 9, GPA = 3.89, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Hayden", Age = 23, Friends = 1, GPA = 1.97, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Bailey", Age = 19, Friends = 12, GPA = 2.87, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "David", Age = 17, Friends = 0, GPA = 2.06, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Harper", Age = 25, Friends = 8, GPA = 3.39, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Cameron", Age = 40, Friends = 2, GPA = 2.39, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Jillian", Age = 38, Friends = 10, GPA = 3.28, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Joseph", Age = 20, Friends = 1, GPA = 1.92, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Mackenzie", Age = 26, Friends = 8, GPA = 2.83, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Austin", Age = 38, Friends = 2, GPA = 1.63, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Alexa", Age = 19, Friends = 12, GPA = 3.37, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Hunter", Age = 26, Friends = 1, GPA = 0.42, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Esme", Age = 38, Friends = 10, GPA = 3.24, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Colton", Age = 28, Friends = 1, GPA = 1.34, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Gabrielle", Age = 33, Friends = 8, GPA = 2.51, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Brody", Age = 40, Friends = 0, GPA = 1.00, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Lydia", Age = 20, Friends = 7, GPA = 2.65, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Blake", Age = 22, Friends = 2, GPA = 1.25, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Kayla", Age = 37, Friends = 14, GPA = 4.06, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Rhys", Age = 35, Friends = 3, GPA = 1.69, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Rosalie", Age = 39, Friends = 8, GPA = 3.40, Grade = Grade.C, Tall = false, Nice = true},
				new Student { Name = "Gage", Age = 35, Friends = 3, GPA = 1.07, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Zoey", Age = 25, Friends = 9, GPA = 4.10, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Jonathan", Age = 32, Friends = 0, GPA = 1.72, Grade = Grade.D, Tall = false, Nice = false},
				new Student { Name = "Brianna", Age = 35, Friends = 9, GPA = 2.66, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Riley", Age = 23, Friends = 1, GPA = 0.61, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Isla", Age = 22, Friends = 5, GPA = 3.55, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Joel", Age = 40, Friends = 1, GPA = 1.15, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Taylor", Age = 18, Friends = 11, GPA = 3.64, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Brandon", Age = 31, Friends = 0, GPA = 1.16, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Brooke", Age = 25, Friends = 9, GPA = 2.72, Grade = Grade.C, Tall = true, Nice = true},
				new Student { Name = "Jude", Age = 17, Friends = 0, GPA = 1.44, Grade = Grade.F, Tall = true, Nice = false},
				new Student { Name = "Adalyn", Age = 18, Friends = 9, GPA = 2.66, Grade = Grade.B, Tall = true, Nice = true},
				new Student { Name = "Jason", Age = 32, Friends = 1, GPA = 1.03, Grade = Grade.C, Tall = true, Nice = false},
				new Student { Name = "Lorelei", Age = 26, Friends = 8, GPA = 4.04, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "Anthony", Age = 28, Friends = 3, GPA = 0.89, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Julia", Age = 21, Friends = 8, GPA = 3.86, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Nolan", Age = 34, Friends = 1, GPA = 1.86, Grade = Grade.F, Tall = false, Nice = false},
				new Student { Name = "Reagan", Age = 34, Friends = 7, GPA = 3.71, Grade = Grade.B, Tall = false, Nice = true},
				new Student { Name = "Cooper", Age = 37, Friends = 2, GPA = 1.13, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Faith", Age = 23, Friends = 9, GPA = 2.63, Grade = Grade.A, Tall = true, Nice = true},
				new Student { Name = "Maddox", Age = 21, Friends = 3, GPA = 2.30, Grade = Grade.D, Tall = true, Nice = false},
				new Student { Name = "Sydney", Age = 39, Friends = 7, GPA = 2.64, Grade = Grade.A, Tall = false, Nice = true},
				new Student { Name = "John", Age = 22, Friends = 1, GPA = 1.17, Grade = Grade.C, Tall = false, Nice = false},
				new Student { Name = "Jasmine", Age = 20, Friends = 8, GPA = 2.53, Grade = Grade.B, Tall = false, Nice = true},
			};
		}
	}
}
