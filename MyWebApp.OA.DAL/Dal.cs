﻿ 
using MyWebApp.OA.IDAL;
using MyWebApp.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyWebApp.OA.DAL
{
   
	
	public partial class ActionInfoDal :BaseDal<ActionInfo>,IActionInfoDal
    {
      
    }
	
	public partial class BillDal :BaseDal<Bill>,IBillDal
    {
      
    }
	
	public partial class BillTypeDal :BaseDal<BillType>,IBillTypeDal
    {
      
    }
	
	public partial class CurrentUnitDal :BaseDal<CurrentUnit>,ICurrentUnitDal
    {
      
    }
	
	public partial class DepartmentDal :BaseDal<Department>,IDepartmentDal
    {
      
    }
	
	public partial class FileInfoDal :BaseDal<FileInfo>,IFileInfoDal
    {
      
    }
	
	public partial class PayTypeDal :BaseDal<PayType>,IPayTypeDal
    {
      
    }
	
	public partial class R_UserInfo_ActionInfoDal :BaseDal<R_UserInfo_ActionInfo>,IR_UserInfo_ActionInfoDal
    {
      
    }
	
	public partial class RoleInfoDal :BaseDal<RoleInfo>,IRoleInfoDal
    {
      
    }
	
	public partial class UserInfoDal :BaseDal<UserInfo>,IUserInfoDal
    {
      
    }
	
	public partial class WF_InstanceDal :BaseDal<WF_Instance>,IWF_InstanceDal
    {
      
    }
	
	public partial class WF_StepInfoDal :BaseDal<WF_StepInfo>,IWF_StepInfoDal
    {
      
    }
	
	public partial class WF_TempDal :BaseDal<WF_Temp>,IWF_TempDal
    {
      
    }
	
}