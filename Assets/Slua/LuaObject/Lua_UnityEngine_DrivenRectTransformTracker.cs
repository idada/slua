﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DrivenRectTransformTracker : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try{
			UnityEngine.DrivenRectTransformTracker self=checkSelf<UnityEngine.DrivenRectTransformTracker>(l);
			UnityEngine.Object a1;
			checkType(l,2,out a1);
			UnityEngine.RectTransform a2;
			checkType(l,3,out a2);
			UnityEngine.DrivenTransformProperties a3;
			checkType(l,4,out a3);
			self.Add(a1,a2,a3);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			UnityEngine.DrivenRectTransformTracker self=checkSelf<UnityEngine.DrivenRectTransformTracker>(l);
			self.Clear();
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DrivenRectTransformTracker");
		addMember(l,Add, "Add");
		addMember(l,Clear, "Clear");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.DrivenRectTransformTracker));
		LuaDLL.lua_pop(l, 1);
	}
}
