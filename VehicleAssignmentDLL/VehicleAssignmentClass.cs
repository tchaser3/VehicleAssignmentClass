/* Title:           Vehicle Assignment Class
 * Date:            6-23-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehicleAssignmentDLL
{
    public class VehicleAssignmentClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        VehicleAssignmentDataSet aVehicleAssignmentDataSet;
        VehicleAssignmentDataSetTableAdapters.vehicleassignmentTableAdapter aVehicleAssignmentTableAdapter;

        InsertVehicleAssignmentEntryTableAdapters.QueriesTableAdapter aInsertVehicleAssignmentTableAdapter;

        UpdateCurentAssignedVehicleEntryTableAdapters.QueriesTableAdapter aUpdateCurrentAssignedVehicleTableAdapter;

        FindCurrentVehicleAssignmentsDataSet aFindCurrentVehicleAssignmentsDataSet;
        FindCurrentVehicleAssignmentsDataSetTableAdapters.FindCurrentVehicleAssignmentsTableAdapter aFindCurrentVehicleAssignmentsTableAdapter;

        FindAssignedVehicleByVehicleIDAndDateRangeDataSet aFindAssignedVehicleByVehicleIDAndDateRangeDataSet;
        FindAssignedVehicleByVehicleIDAndDateRangeDataSetTableAdapters.FindAssignedVehicleByVehicleIDAndDateRangeTableAdapter aFindAssignedVehicleByVehicleIDAndDateRangeTableAdapter;

        FindAssignedVehicleByDateRangeDataSet aFindAssignedVehicleByDateRangeDataSet;
        FindAssignedVehicleByDateRangeDataSetTableAdapters.FindAssignedVehiclesByDateRangeTableAdapter aFindAssignedVehicleByDateRangeTableAdapter;

        FindAssignedVehicleByEmployeeIDAndDateRangeDataSet aFindAssignedVehicleByEmployeeIDAndDateRangeDataSet;
        FindAssignedVehicleByEmployeeIDAndDateRangeDataSetTableAdapters.FindAssignedVehiclesByEmployeeIDAndDateRangeTableAdapter aFindAssignedVehicleByEmployeeIDAndDateRangeTableAdapter;

        FindCurrentAssignedVehicleByVehicleIDDataSet aFindCurrentAssignedVehicleByVehicleIDDataSet;
        FindCurrentAssignedVehicleByVehicleIDDataSetTableAdapters.FindCurrentAssignedVehicleByVehicleIDTableAdapter aFindCurrentAssignedVehicleByVehicleIDTableAdapter;

        FindCurrentAssignedVehicleMainByVehicleIDDataSet aFindCurrentAssignedVehicleMainByVehicleIDDataSet;
        FindCurrentAssignedVehicleMainByVehicleIDDataSetTableAdapters.FindCurrentAssignedVehicleMainByVehicleIDTableAdapter aFindCurrentAssignedVehicleMainByVehicleIDTableAdapter;

        FindCurrentVehicleMainAssignmentsDataSet aFindCurrentVehicleMainAssignmentsDataSet;
        FindCurrentVehicleMainAssignmentsDataSetTableAdapters.FindCurrentVehicleMainAssignmentsTableAdapter aFindCurrentVehicleMainAssignmentsTableAdapter;

        FindCurrentVehicleAssignmentByEmployeeIDDataSet aFindCurrentVehicleAssignmentByEmployeeIDDataSet;
        FindCurrentVehicleAssignmentByEmployeeIDDataSetTableAdapters.FindCurrentVehicleMainAssignmentByEmployeeIDTableAdapter aFindCurrentVehicleAssignmentByEmployeeIDTableAdapter;

        public FindCurrentVehicleAssignmentByEmployeeIDDataSet FindCurrentVehicleAssignmentByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindCurrentVehicleAssignmentByEmployeeIDDataSet = new FindCurrentVehicleAssignmentByEmployeeIDDataSet();
                aFindCurrentVehicleAssignmentByEmployeeIDTableAdapter = new FindCurrentVehicleAssignmentByEmployeeIDDataSetTableAdapters.FindCurrentVehicleMainAssignmentByEmployeeIDTableAdapter();
                aFindCurrentVehicleAssignmentByEmployeeIDTableAdapter.Fill(aFindCurrentVehicleAssignmentByEmployeeIDDataSet.FindCurrentVehicleMainAssignmentByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Find Current Vehicle Assignment By Employee ID " + Ex.Message);
            }

            return aFindCurrentVehicleAssignmentByEmployeeIDDataSet;
        }
        public FindCurrentVehicleMainAssignmentsDataSet FindCurrentVehicleMainAssignments()
        {
            try
            {
                aFindCurrentVehicleMainAssignmentsDataSet = new FindCurrentVehicleMainAssignmentsDataSet();
                aFindCurrentVehicleMainAssignmentsTableAdapter = new FindCurrentVehicleMainAssignmentsDataSetTableAdapters.FindCurrentVehicleMainAssignmentsTableAdapter();
                aFindCurrentVehicleMainAssignmentsTableAdapter.Fill(aFindCurrentVehicleMainAssignmentsDataSet.FindCurrentVehicleMainAssignments);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Find Current Vehicle Main Assignment " + Ex.Message);
            }

            return aFindCurrentVehicleMainAssignmentsDataSet;
        }
        public FindCurrentAssignedVehicleMainByVehicleIDDataSet FindCurrentAssignedVehicleMainByVehicleID(int intVehicleID)
        {
            try
            {
                aFindCurrentAssignedVehicleMainByVehicleIDDataSet = new FindCurrentAssignedVehicleMainByVehicleIDDataSet();
                aFindCurrentAssignedVehicleMainByVehicleIDTableAdapter = new FindCurrentAssignedVehicleMainByVehicleIDDataSetTableAdapters.FindCurrentAssignedVehicleMainByVehicleIDTableAdapter();
                aFindCurrentAssignedVehicleMainByVehicleIDTableAdapter.Fill(aFindCurrentAssignedVehicleMainByVehicleIDDataSet.FindCurrentAssignedVehicleMainByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Find Current Assigned Vehicle Main By Vehicle ID " + Ex.Message);
            }


            return aFindCurrentAssignedVehicleMainByVehicleIDDataSet;
        }
        public FindCurrentAssignedVehicleByVehicleIDDataSet FindCurrentAssignedVehicleByVehicleID(int intVehicleID)
        {
            try
            {
                aFindCurrentAssignedVehicleByVehicleIDDataSet = new FindCurrentAssignedVehicleByVehicleIDDataSet();
                aFindCurrentAssignedVehicleByVehicleIDTableAdapter = new FindCurrentAssignedVehicleByVehicleIDDataSetTableAdapters.FindCurrentAssignedVehicleByVehicleIDTableAdapter();
                aFindCurrentAssignedVehicleByVehicleIDTableAdapter.Fill(aFindCurrentAssignedVehicleByVehicleIDDataSet.FindCurrentAssignedVehicleByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Find Current Assigned Vehicle By Vehicle ID " + Ex.Message);
            }

            return aFindCurrentAssignedVehicleByVehicleIDDataSet;
        }
        public FindAssignedVehicleByEmployeeIDAndDateRangeDataSet FindAssignedVehicleByEmployeeIDAndDateRange(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAssignedVehicleByEmployeeIDAndDateRangeDataSet = new FindAssignedVehicleByEmployeeIDAndDateRangeDataSet();
                aFindAssignedVehicleByEmployeeIDAndDateRangeTableAdapter = new FindAssignedVehicleByEmployeeIDAndDateRangeDataSetTableAdapters.FindAssignedVehiclesByEmployeeIDAndDateRangeTableAdapter();
                aFindAssignedVehicleByEmployeeIDAndDateRangeTableAdapter.Fill(aFindAssignedVehicleByEmployeeIDAndDateRangeDataSet.FindAssignedVehiclesByEmployeeIDAndDateRange, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignement Class // Find Assigned Vehicle By Employee ID And Date Range " + Ex.Message);
            }

            return aFindAssignedVehicleByEmployeeIDAndDateRangeDataSet;
        }
        public FindAssignedVehicleByDateRangeDataSet FindAssignedVehicleByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAssignedVehicleByDateRangeDataSet = new FindAssignedVehicleByDateRangeDataSet();
                aFindAssignedVehicleByDateRangeTableAdapter = new FindAssignedVehicleByDateRangeDataSetTableAdapters.FindAssignedVehiclesByDateRangeTableAdapter();
                aFindAssignedVehicleByDateRangeTableAdapter.Fill(aFindAssignedVehicleByDateRangeDataSet.FindAssignedVehiclesByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Find Assigned Vehicle By Date Range " + Ex.Message);
            }

            return aFindAssignedVehicleByDateRangeDataSet;
        }
        public FindAssignedVehicleByVehicleIDAndDateRangeDataSet FindAssignedVehicleByVehicleIDAndDateRange(int intVehicleID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAssignedVehicleByVehicleIDAndDateRangeDataSet = new FindAssignedVehicleByVehicleIDAndDateRangeDataSet();
                aFindAssignedVehicleByVehicleIDAndDateRangeTableAdapter = new FindAssignedVehicleByVehicleIDAndDateRangeDataSetTableAdapters.FindAssignedVehicleByVehicleIDAndDateRangeTableAdapter();
                aFindAssignedVehicleByVehicleIDAndDateRangeTableAdapter.Fill(aFindAssignedVehicleByVehicleIDAndDateRangeDataSet.FindAssignedVehicleByVehicleIDAndDateRange, intVehicleID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignement Class // Find Assigned Vehicle By Vehicle ID And Date Range " + Ex.Message);
            }

            return aFindAssignedVehicleByVehicleIDAndDateRangeDataSet;
        }
        public FindCurrentVehicleAssignmentsDataSet FindCurrentVehicleAssignments()
        {
            try
            {
                aFindCurrentVehicleAssignmentsDataSet = new FindCurrentVehicleAssignmentsDataSet();
                aFindCurrentVehicleAssignmentsTableAdapter = new FindCurrentVehicleAssignmentsDataSetTableAdapters.FindCurrentVehicleAssignmentsTableAdapter();
                aFindCurrentVehicleAssignmentsTableAdapter.Fill(aFindCurrentVehicleAssignmentsDataSet.FindCurrentVehicleAssignments);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Find Current Vehicle Assignments " + Ex.Message);
            }

            return aFindCurrentVehicleAssignmentsDataSet;
        }
        public bool UpdateCurrentVehicleAssignment(int intTransactionID, bool blnCurrentAssignment)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateCurrentAssignedVehicleTableAdapter = new UpdateCurentAssignedVehicleEntryTableAdapters.QueriesTableAdapter();
                aUpdateCurrentAssignedVehicleTableAdapter.UpdateCurrentAssignedVehicle(intTransactionID, blnCurrentAssignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Update Current Vehicle Assignment " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertVehicleAssignment(int intVehicleID, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleAssignmentTableAdapter = new InsertVehicleAssignmentEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleAssignmentTableAdapter.InsertVehicleAssignment(intVehicleID, intEmployeeID, DateTime.Now, true);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Insert Vehicle Assignment " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public VehicleAssignmentDataSet GetVehicleAssignmentInfo()
        {
            try
            {
                aVehicleAssignmentDataSet = new VehicleAssignmentDataSet();
                aVehicleAssignmentTableAdapter = new VehicleAssignmentDataSetTableAdapters.vehicleassignmentTableAdapter();
                aVehicleAssignmentTableAdapter.Fill(aVehicleAssignmentDataSet.vehicleassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Get Vehicle Assignment Info " + Ex.Message);
            }

            return aVehicleAssignmentDataSet;
        }
        public void UpdateVehicleAssignmentDB(VehicleAssignmentDataSet aVehicleAssignmentDataSet)
        {
            try
            {
                aVehicleAssignmentTableAdapter = new VehicleAssignmentDataSetTableAdapters.vehicleassignmentTableAdapter();
                aVehicleAssignmentTableAdapter.Update(aVehicleAssignmentDataSet.vehicleassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Assignment Class // Update Vehicle Assignment DB " + Ex.Message);
            }
        }
    }
}
