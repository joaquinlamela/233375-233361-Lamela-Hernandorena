﻿using BusinessLogicExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class AlarmManagement
	{
		private List<Alarm> alarmList;

		public AlarmManagement()
		{
			alarmList = new List<Alarm>(); 
		}

		public void AddAlarm(Alarm alarm)
		{
			VerifyFormatAlarm(alarm);
			alarmList.Add(alarm); 
		}

		public void VerifyFormatAlarm(Alarm alarm)
		{
			if (IsNegativeQuantity(alarm.QuantityPost))
			{
				throw new AlarmManagementException(MessagesExceptions.ERROR_IS_NEGATIVE); 
			}

			if (ExistAlarm(alarm))
			{
				throw new AlarmManagementException(MessagesExceptions.ERROR_IS_CONTAINED); 
			}

			if (AlarmEntityIsNull(alarm))
            {
                throw new AlarmManagementException(MessagesExceptions.ERROR_IS_NULL); 
            }

            if (IsNegativeQuantity(alarm.QuantityTime))
            {
                throw new AlarmManagementException(MessagesExceptions.ERROR_IS_NEGATIVE); 
            }
		}

		private bool AlarmEntityIsNull(Alarm alarm)
		{
			return alarm.Entity == null;
		}



		private bool ExistAlarm(Alarm alarm)
		{
			return alarmList.Contains(alarm); 
		}

		private bool IsNegativeQuantity(double quantity)
		{
			return quantity <= 0; 
		}

		public Alarm[] allAlarms
		{
			get { return alarmList.ToArray(); }
		}
	}
}