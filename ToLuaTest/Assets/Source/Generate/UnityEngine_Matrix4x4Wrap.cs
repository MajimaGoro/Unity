﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Matrix4x4Wrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Matrix4x4), null);
		L.RegFunction("Inverse", Inverse);
		L.RegFunction("Transpose", Transpose);
		L.RegFunction("ValidTRS", ValidTRS);
		L.RegFunction("Determinant", Determinant);
		L.RegFunction("SetTRS", SetTRS);
		L.RegFunction("TRS", TRS);
		L.RegFunction("Ortho", Ortho);
		L.RegFunction("Perspective", Perspective);
		L.RegFunction("LookAt", LookAt);
		L.RegFunction("Frustum", Frustum);
		L.RegFunction("get_Item", get_Item);
		L.RegFunction("set_Item", set_Item);
		L.RegFunction("GetHashCode", GetHashCode);
		L.RegFunction("Equals", Equals);
		L.RegFunction("GetColumn", GetColumn);
		L.RegFunction("GetRow", GetRow);
		L.RegFunction("SetColumn", SetColumn);
		L.RegFunction("SetRow", SetRow);
		L.RegFunction("MultiplyPoint", MultiplyPoint);
		L.RegFunction("MultiplyPoint3x4", MultiplyPoint3x4);
		L.RegFunction("MultiplyVector", MultiplyVector);
		L.RegFunction("TransformPlane", TransformPlane);
		L.RegFunction("Scale", Scale);
		L.RegFunction("Translate", Translate);
		L.RegFunction("Rotate", Rotate);
		L.RegFunction("ToString", ToString);
		L.RegFunction("New", _CreateUnityEngine_Matrix4x4);
		L.RegVar("this", _this, null);
		L.RegFunction("__mul", op_Multiply);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("m00", get_m00, set_m00);
		L.RegVar("m10", get_m10, set_m10);
		L.RegVar("m20", get_m20, set_m20);
		L.RegVar("m30", get_m30, set_m30);
		L.RegVar("m01", get_m01, set_m01);
		L.RegVar("m11", get_m11, set_m11);
		L.RegVar("m21", get_m21, set_m21);
		L.RegVar("m31", get_m31, set_m31);
		L.RegVar("m02", get_m02, set_m02);
		L.RegVar("m12", get_m12, set_m12);
		L.RegVar("m22", get_m22, set_m22);
		L.RegVar("m32", get_m32, set_m32);
		L.RegVar("m03", get_m03, set_m03);
		L.RegVar("m13", get_m13, set_m13);
		L.RegVar("m23", get_m23, set_m23);
		L.RegVar("m33", get_m33, set_m33);
		L.RegVar("inverse", get_inverse, null);
		L.RegVar("transpose", get_transpose, null);
		L.RegVar("rotation", get_rotation, null);
		L.RegVar("lossyScale", get_lossyScale, null);
		L.RegVar("isIdentity", get_isIdentity, null);
		L.RegVar("determinant", get_determinant, null);
		L.RegVar("decomposeProjection", get_decomposeProjection, null);
		L.RegVar("zero", get_zero, null);
		L.RegVar("identity", get_identity, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Matrix4x4(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				UnityEngine.Vector4 arg0 = ToLua.ToVector4(L, 1);
				UnityEngine.Vector4 arg1 = ToLua.ToVector4(L, 2);
				UnityEngine.Vector4 arg2 = ToLua.ToVector4(L, 3);
				UnityEngine.Vector4 arg3 = ToLua.ToVector4(L, 4);
				UnityEngine.Matrix4x4 obj = new UnityEngine.Matrix4x4(arg0, arg1, arg2, arg3);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 0)
			{
				UnityEngine.Matrix4x4 obj = new UnityEngine.Matrix4x4();
				ToLua.PushValue(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Matrix4x4.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				float o = obj[arg0];
				LuaDLL.lua_pushnumber(L, o);
				ToLua.SetBack(L, 1, obj);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				float o = obj[arg0, arg1];
				LuaDLL.lua_pushnumber(L, o);
				ToLua.SetBack(L, 1, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to operator method: UnityEngine.Matrix4x4.this");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _set_this(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				obj[arg0] = arg1;
				ToLua.SetBack(L, 1, obj);
				return 0;
			}
			else if (count == 4)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				obj[arg0, arg1] = arg2;
				ToLua.SetBack(L, 1, obj);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to operator method: UnityEngine.Matrix4x4.this");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, _set_this);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Inverse(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Matrix4x4 arg0 = StackTraits<UnityEngine.Matrix4x4>.Check(L, 1);
			UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.Inverse(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Transpose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Matrix4x4 arg0 = StackTraits<UnityEngine.Matrix4x4>.Check(L, 1);
			UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.Transpose(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ValidTRS(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			bool o = obj.ValidTRS();
			LuaDLL.lua_pushboolean(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Determinant(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Matrix4x4 arg0 = StackTraits<UnityEngine.Matrix4x4>.Check(L, 1);
			float o = UnityEngine.Matrix4x4.Determinant(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTRS(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Quaternion arg1 = ToLua.ToQuaternion(L, 3);
			UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 4);
			obj.SetTRS(arg0, arg1, arg2);
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TRS(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
			UnityEngine.Quaternion arg1 = ToLua.ToQuaternion(L, 2);
			UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 3);
			UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.TRS(arg0, arg1, arg2);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Ortho(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			float arg5 = (float)LuaDLL.luaL_checknumber(L, 6);
			UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.Ortho(arg0, arg1, arg2, arg3, arg4, arg5);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Perspective(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.Perspective(arg0, arg1, arg2, arg3);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LookAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 3);
			UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.LookAt(arg0, arg1, arg2);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Frustum(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.FrustumPlanes arg0 = StackTraits<UnityEngine.FrustumPlanes>.Check(L, 1);
				UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.Frustum(arg0);
				ToLua.PushValue(L, o);
				return 1;
			}
			else if (count == 6)
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
				float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
				float arg5 = (float)LuaDLL.luaL_checknumber(L, 6);
				UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.Frustum(arg0, arg1, arg2, arg3, arg4, arg5);
				ToLua.PushValue(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Matrix4x4.Frustum");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				float o = obj[arg0];
				LuaDLL.lua_pushnumber(L, o);
				ToLua.SetBack(L, 1, obj);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				float o = obj[arg0, arg1];
				LuaDLL.lua_pushnumber(L, o);
				ToLua.SetBack(L, 1, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Matrix4x4.get_Item");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				obj[arg0] = arg1;
				ToLua.SetBack(L, 1, obj);
				return 0;
			}
			else if (count == 4)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				obj[arg0, arg1] = arg2;
				ToLua.SetBack(L, 1, obj);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Matrix4x4.set_Item");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			int o = obj.GetHashCode();
			LuaDLL.lua_pushinteger(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj.Equals(arg0);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Multiply(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Vector4>(L, 2))
			{
				UnityEngine.Matrix4x4 arg0 = StackTraits<UnityEngine.Matrix4x4>.Check(L, 1);
				UnityEngine.Vector4 arg1 = ToLua.ToVector4(L, 2);
				UnityEngine.Vector4 o = arg0 * arg1;
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Matrix4x4>(L, 2))
			{
				UnityEngine.Matrix4x4 arg0 = StackTraits<UnityEngine.Matrix4x4>.Check(L, 1);
				UnityEngine.Matrix4x4 arg1 = StackTraits<UnityEngine.Matrix4x4>.To(L, 2);
				UnityEngine.Matrix4x4 o = arg0 * arg1;
				ToLua.PushValue(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Matrix4x4.op_Multiply");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Matrix4x4 arg0 = StackTraits<UnityEngine.Matrix4x4>.To(L, 1);
			UnityEngine.Matrix4x4 arg1 = StackTraits<UnityEngine.Matrix4x4>.To(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetColumn(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector4 o = obj.GetColumn(arg0);
			ToLua.Push(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector4 o = obj.GetRow(arg0);
			ToLua.Push(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetColumn(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector4 arg1 = ToLua.ToVector4(L, 3);
			obj.SetColumn(arg0, arg1);
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector4 arg1 = ToLua.ToVector4(L, 3);
			obj.SetRow(arg0, arg1);
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MultiplyPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 o = obj.MultiplyPoint(arg0);
			ToLua.Push(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MultiplyPoint3x4(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 o = obj.MultiplyPoint3x4(arg0);
			ToLua.Push(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MultiplyVector(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 o = obj.MultiplyVector(arg0);
			ToLua.Push(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransformPlane(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
			UnityEngine.Plane arg0 = StackTraits<UnityEngine.Plane>.Check(L, 2);
			UnityEngine.Plane o = obj.TransformPlane(arg0);
			ToLua.PushValue(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Scale(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
			UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.Scale(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Translate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
			UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.Translate(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rotate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Quaternion arg0 = ToLua.ToQuaternion(L, 1);
			UnityEngine.Matrix4x4 o = UnityEngine.Matrix4x4.Rotate(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				string o = obj.ToString();
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Matrix4x4));
				string arg0 = ToLua.CheckString(L, 2);
				string o = obj.ToString(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Matrix4x4.ToString");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m00(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m00;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m00 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m10(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m10;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m10 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m20(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m20;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m20 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m30(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m30;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m30 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m01(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m01;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m01 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m11(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m11;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m11 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m21(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m21;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m21 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m31(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m31;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m31 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m02(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m02;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m02 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m12(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m12;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m12 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m22(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m22;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m22 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m32(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m32;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m32 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m03(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m03;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m03 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m13(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m13;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m13 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m23(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m23;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m23 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m33(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.m33;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m33 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inverse(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			UnityEngine.Matrix4x4 ret = obj.inverse;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inverse on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transpose(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			UnityEngine.Matrix4x4 ret = obj.transpose;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transpose on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			UnityEngine.Quaternion ret = obj.rotation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lossyScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			UnityEngine.Vector3 ret = obj.lossyScale;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lossyScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isIdentity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			bool ret = obj.isIdentity;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isIdentity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_determinant(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float ret = obj.determinant;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index determinant on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_decomposeProjection(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			UnityEngine.FrustumPlanes ret = obj.decomposeProjection;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index decomposeProjection on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_zero(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.Matrix4x4.zero);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_identity(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.Matrix4x4.identity);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m00(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m00 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m00 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m10(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m10 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m10 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m20(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m20 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m20 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m30(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m30 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m30 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m01(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m01 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m01 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m11(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m11 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m11 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m21(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m21 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m21 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m31(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m31 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m31 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m02(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m02 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m02 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m12(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m12 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m12 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m22(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m22 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m22 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m32(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m32 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m32 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m03(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m03 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m03 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m13(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m13 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m13 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m23(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m23 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m23 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m33(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Matrix4x4 obj = (UnityEngine.Matrix4x4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.m33 = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index m33 on a nil value");
		}
	}
}

