using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kclinic.Models.ViewModels
{
	public class HomeVM
	{
		public IEnumerable<Kclinic.Models.Blog> Blogs { get; set; }
		public IEnumerable<Kclinic.Models.Product> Products { get; set; }
		public Trial Trial { get;set; }
	}
}
