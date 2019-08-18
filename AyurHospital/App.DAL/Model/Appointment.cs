using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App.DAL.Model
{
	[Table("Appointment", Schema = "Appointment")]
	public class Appointment
	{	
		[Key]
		public int AppointmentId { get; set; }
		
		[MaxLength(60)]
		public string Name { get; set; }
		
	}
}
