﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleAnimator : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ParticleAnimator o;
		if(matchType(l,1)){
			o=new UnityEngine.ParticleAnimator();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_doesAnimateColor(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		pushValue(l,o.doesAnimateColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_doesAnimateColor(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.doesAnimateColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldRotationAxis(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		pushValue(l,o.worldRotationAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldRotationAxis(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.worldRotationAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localRotationAxis(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		pushValue(l,o.localRotationAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localRotationAxis(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.localRotationAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sizeGrow(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		pushValue(l,o.sizeGrow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sizeGrow(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		System.Single v;
		checkType(l,2,out v);
		o.sizeGrow=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndForce(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		pushValue(l,o.rndForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndForce(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.rndForce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_force(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		pushValue(l,o.force);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_force(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.force=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_damping(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		pushValue(l,o.damping);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_damping(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		System.Single v;
		checkType(l,2,out v);
		o.damping=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autodestruct(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		pushValue(l,o.autodestruct);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autodestruct(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.autodestruct=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorAnimation(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		pushValue(l,o.colorAnimation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colorAnimation(IntPtr l) {
		UnityEngine.ParticleAnimator o = checkSelf<UnityEngine.ParticleAnimator>(l);
		UnityEngine.Color[] v;
		checkType(l,2,out v);
		o.colorAnimation=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleAnimator");
		addMember(l,get_doesAnimateColor, "get_doesAnimateColor");
		addMember(l,set_doesAnimateColor, "set_doesAnimateColor");
		addMember(l,get_worldRotationAxis, "get_worldRotationAxis");
		addMember(l,set_worldRotationAxis, "set_worldRotationAxis");
		addMember(l,get_localRotationAxis, "get_localRotationAxis");
		addMember(l,set_localRotationAxis, "set_localRotationAxis");
		addMember(l,get_sizeGrow, "get_sizeGrow");
		addMember(l,set_sizeGrow, "set_sizeGrow");
		addMember(l,get_rndForce, "get_rndForce");
		addMember(l,set_rndForce, "set_rndForce");
		addMember(l,get_force, "get_force");
		addMember(l,set_force, "set_force");
		addMember(l,get_damping, "get_damping");
		addMember(l,set_damping, "set_damping");
		addMember(l,get_autodestruct, "get_autodestruct");
		addMember(l,set_autodestruct, "set_autodestruct");
		addMember(l,get_colorAnimation, "get_colorAnimation");
		addMember(l,set_colorAnimation, "set_colorAnimation");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ParticleAnimator),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
