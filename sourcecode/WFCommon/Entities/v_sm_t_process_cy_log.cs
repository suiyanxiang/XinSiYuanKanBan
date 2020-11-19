using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using Dapper;
using DapperExtensions;
using DapperExtensions.Mapper;

namespace WFCommon
{
	public class v_sm_t_process_cy_log_CLASSMAPPER : ClassMapper<v_sm_t_process_cy_log>
	{
		public v_sm_t_process_cy_log_CLASSMAPPER()
		{
			AutoMap();
		}
	}
	public class v_sm_t_process_cy_log
	{
		public string LogId { get; set; }
		public string InstanceId { get; set; }
		public string LogDate { get; set; }
		public string LogUser { get; set; }
		public string VerifyUser { get; set; }
		public string ADC { get; set; }
		public string ATJC { get; set; }
		public string AIzn { get; set; }
		public string AMF1 { get; set; }
		public string AMF2 { get; set; }
		public string BDC { get; set; }
		public string BTJC { get; set; }
		public string BIzn { get; set; }
		public string BMF1 { get; set; }
		public string BMF2 { get; set; }
	}
}