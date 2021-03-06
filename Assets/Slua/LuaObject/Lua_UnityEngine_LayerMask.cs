﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LayerMask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LayerToName(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.String ret=UnityEngine.LayerMask.LayerToName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int NameToLayer(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.LayerMask.NameToLayer(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMask(IntPtr l) {
		try{
			System.String[] a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.LayerMask.GetMask(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UnityEngine.LayerMask o = checkSelf<UnityEngine.LayerMask>(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UnityEngine.LayerMask o = checkSelf<UnityEngine.LayerMask>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.value=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LayerMask");
		addMember(l,LayerToName, "LayerToName");
		addMember(l,NameToLayer, "NameToLayer");
		addMember(l,GetMask, "GetMask");
		addMember(l,get_value, "get_value");
		addMember(l,set_value, "set_value");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.LayerMask));
		LuaDLL.lua_pop(l, 1);
	}
}
