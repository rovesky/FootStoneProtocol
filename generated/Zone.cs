// **********************************************************************
//
// Copyright (c) 2003-2018 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************
//
// Ice version 3.7.1
//
// <auto-generated>
//
// Generated from file `Zone.ice'
//
// Warning: do not edit this file.
//
// </auto-generated>
//


using _System = global::System;

#pragma warning disable 1591

namespace IceCompactId
{
}

namespace FootStone
{
    namespace GrainInterfaces
    {
        [_System.Runtime.InteropServices.ComVisible(false)]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
        public partial interface IZonePush : Ice.Object, IZonePushOperations_
        {
        }

        [_System.Runtime.InteropServices.ComVisible(false)]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
        public partial interface IZone : Ice.Object, IZoneOperations_
        {
        }
    }
}

namespace FootStone
{
    namespace GrainInterfaces
    {
        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public delegate void Callback_IZonePush_ZoneSync();

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public delegate void Callback_IZone_PlayerEnter();

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public delegate void Callback_IZone_Move();
    }
}

namespace FootStone
{
    namespace GrainInterfaces
    {
        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public interface IZonePushPrx : Ice.ObjectPrx
        {
            void ZoneSync(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext());

            _System.Threading.Tasks.Task ZoneSyncAsync(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext(), _System.IProgress<bool> progress = null, _System.Threading.CancellationToken cancel = new _System.Threading.CancellationToken());

            Ice.AsyncResult<Callback_IZonePush_ZoneSync> begin_ZoneSync(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext());

            Ice.AsyncResult begin_ZoneSync(byte[] data, Ice.AsyncCallback callback, object cookie);

            Ice.AsyncResult begin_ZoneSync(byte[] data, Ice.OptionalContext context, Ice.AsyncCallback callback, object cookie);

            void end_ZoneSync(Ice.AsyncResult asyncResult);
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public interface IZonePrx : Ice.ObjectPrx
        {
            void PlayerEnter(string zoneId, Ice.OptionalContext context = new Ice.OptionalContext());

            _System.Threading.Tasks.Task PlayerEnterAsync(string zoneId, Ice.OptionalContext context = new Ice.OptionalContext(), _System.IProgress<bool> progress = null, _System.Threading.CancellationToken cancel = new _System.Threading.CancellationToken());

            Ice.AsyncResult<Callback_IZone_PlayerEnter> begin_PlayerEnter(string zoneId, Ice.OptionalContext context = new Ice.OptionalContext());

            Ice.AsyncResult begin_PlayerEnter(string zoneId, Ice.AsyncCallback callback, object cookie);

            Ice.AsyncResult begin_PlayerEnter(string zoneId, Ice.OptionalContext context, Ice.AsyncCallback callback, object cookie);

            void end_PlayerEnter(Ice.AsyncResult asyncResult);

            void Move(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext());

            _System.Threading.Tasks.Task MoveAsync(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext(), _System.IProgress<bool> progress = null, _System.Threading.CancellationToken cancel = new _System.Threading.CancellationToken());

            Ice.AsyncResult<Callback_IZone_Move> begin_Move(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext());

            Ice.AsyncResult begin_Move(byte[] data, Ice.AsyncCallback callback, object cookie);

            Ice.AsyncResult begin_Move(byte[] data, Ice.OptionalContext context, Ice.AsyncCallback callback, object cookie);

            void end_Move(Ice.AsyncResult asyncResult);
        }
    }
}

namespace FootStone
{
    namespace GrainInterfaces
    {
        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public interface IZonePushOperations_
        {
            [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
            void ZoneSync(byte[] data, Ice.Current current = null);
        }

        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public interface IZoneOperations_
        {
            [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
            void PlayerEnter(string zoneId, Ice.Current current = null);

            [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
            void Move(byte[] data, Ice.Current current = null);
        }
    }
}

namespace FootStone
{
    namespace GrainInterfaces
    {
        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public sealed class BytesHelper
        {
            public static void write(Ice.OutputStream ostr, byte[] v)
            {
                ostr.writeByteSeq(v);
            }

            public static byte[] read(Ice.InputStream istr)
            {
                byte[] v;
                v = istr.readByteSeq();
                return v;
            }
        }

        [_System.Runtime.InteropServices.ComVisible(false)]
        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        [_System.Serializable]
        public sealed class IZonePushPrxHelper : Ice.ObjectPrxHelperBase, IZonePushPrx
        {
            public IZonePushPrxHelper()
            {
            }

            public IZonePushPrxHelper(_System.Runtime.Serialization.SerializationInfo info, _System.Runtime.Serialization.StreamingContext context) : base(info, context)
            {
            }

            #region Synchronous operations

            public void ZoneSync(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext())
            {
                try
                {
                    _iceI_ZoneSyncAsync(data, context, null, _System.Threading.CancellationToken.None, true).Wait();
                }
                catch(_System.AggregateException ex_)
                {
                    throw ex_.InnerException;
                }
            }

            #endregion

            #region Async Task operations

            public _System.Threading.Tasks.Task ZoneSyncAsync(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext(), _System.IProgress<bool> progress = null, _System.Threading.CancellationToken cancel = new _System.Threading.CancellationToken())
            {
                return _iceI_ZoneSyncAsync(data, context, progress, cancel, false);
            }

            private _System.Threading.Tasks.Task _iceI_ZoneSyncAsync(byte[] iceP_data, Ice.OptionalContext context, _System.IProgress<bool> progress, _System.Threading.CancellationToken cancel, bool synchronous)
            {
                var completed = new IceInternal.OperationTaskCompletionCallback<object>(progress, cancel);
                _iceI_ZoneSync(iceP_data, context, synchronous, completed);
                return completed.Task;
            }

            private const string _ZoneSync_name = "ZoneSync";

            private void _iceI_ZoneSync(byte[] iceP_data, _System.Collections.Generic.Dictionary<string, string> context, bool synchronous, IceInternal.OutgoingAsyncCompletionCallback completed)
            {
                var outAsync = getOutgoingAsync<object>(completed);
                outAsync.invoke(
                    _ZoneSync_name,
                    Ice.OperationMode.Normal,
                    Ice.FormatType.DefaultFormat,
                    context,
                    synchronous,
                    write: (Ice.OutputStream ostr) =>
                    {
                        BytesHelper.write(ostr, iceP_data);
                    });
            }

            #endregion

            #region Asynchronous operations

            public Ice.AsyncResult<Callback_IZonePush_ZoneSync> begin_ZoneSync(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext())
            {
                return begin_ZoneSync(data, context, null, null, false);
            }

            public Ice.AsyncResult begin_ZoneSync(byte[] data, Ice.AsyncCallback callback, object cookie)
            {
                return begin_ZoneSync(data, new Ice.OptionalContext(), callback, cookie, false);
            }

            public Ice.AsyncResult begin_ZoneSync(byte[] data, Ice.OptionalContext context, Ice.AsyncCallback callback, object cookie)
            {
                return begin_ZoneSync(data, context, callback, cookie, false);
            }

            public void end_ZoneSync(Ice.AsyncResult asyncResult)
            {
                var resultI_ = IceInternal.AsyncResultI.check(asyncResult, this, _ZoneSync_name);
                ((IceInternal.OutgoingAsyncT<object>)resultI_.OutgoingAsync).getResult(resultI_.wait());
            }

            private Ice.AsyncResult<Callback_IZonePush_ZoneSync> begin_ZoneSync(byte[] iceP_data, _System.Collections.Generic.Dictionary<string, string> context, Ice.AsyncCallback completedCallback, object cookie, bool synchronous)
            {
                var completed = new IceInternal.OperationAsyncResultCompletionCallback<Callback_IZonePush_ZoneSync, object>(
                    (Callback_IZonePush_ZoneSync cb, object ret) =>
                    {
                        if(cb != null)
                        {
                            cb.Invoke();
                        }
                    },
                    this, _ZoneSync_name, cookie, completedCallback);
                _iceI_ZoneSync(iceP_data, context, synchronous, completed);
                return completed;
            }

            #endregion

            #region Checked and unchecked cast operations

            public static IZonePushPrx checkedCast(Ice.ObjectPrx b)
            {
                if(b == null)
                {
                    return null;
                }
                IZonePushPrx r = b as IZonePushPrx;
                if((r == null) && b.ice_isA(ice_staticId()))
                {
                    IZonePushPrxHelper h = new IZonePushPrxHelper();
                    h.iceCopyFrom(b);
                    r = h;
                }
                return r;
            }

            public static IZonePushPrx checkedCast(Ice.ObjectPrx b, _System.Collections.Generic.Dictionary<string, string> ctx)
            {
                if(b == null)
                {
                    return null;
                }
                IZonePushPrx r = b as IZonePushPrx;
                if((r == null) && b.ice_isA(ice_staticId(), ctx))
                {
                    IZonePushPrxHelper h = new IZonePushPrxHelper();
                    h.iceCopyFrom(b);
                    r = h;
                }
                return r;
            }

            public static IZonePushPrx checkedCast(Ice.ObjectPrx b, string f)
            {
                if(b == null)
                {
                    return null;
                }
                Ice.ObjectPrx bb = b.ice_facet(f);
                try
                {
                    if(bb.ice_isA(ice_staticId()))
                    {
                        IZonePushPrxHelper h = new IZonePushPrxHelper();
                        h.iceCopyFrom(bb);
                        return h;
                    }
                }
                catch(Ice.FacetNotExistException)
                {
                }
                return null;
            }

            public static IZonePushPrx checkedCast(Ice.ObjectPrx b, string f, _System.Collections.Generic.Dictionary<string, string> ctx)
            {
                if(b == null)
                {
                    return null;
                }
                Ice.ObjectPrx bb = b.ice_facet(f);
                try
                {
                    if(bb.ice_isA(ice_staticId(), ctx))
                    {
                        IZonePushPrxHelper h = new IZonePushPrxHelper();
                        h.iceCopyFrom(bb);
                        return h;
                    }
                }
                catch(Ice.FacetNotExistException)
                {
                }
                return null;
            }

            public static IZonePushPrx uncheckedCast(Ice.ObjectPrx b)
            {
                if(b == null)
                {
                    return null;
                }
                IZonePushPrx r = b as IZonePushPrx;
                if(r == null)
                {
                    IZonePushPrxHelper h = new IZonePushPrxHelper();
                    h.iceCopyFrom(b);
                    r = h;
                }
                return r;
            }

            public static IZonePushPrx uncheckedCast(Ice.ObjectPrx b, string f)
            {
                if(b == null)
                {
                    return null;
                }
                Ice.ObjectPrx bb = b.ice_facet(f);
                IZonePushPrxHelper h = new IZonePushPrxHelper();
                h.iceCopyFrom(bb);
                return h;
            }

            private static readonly string[] _ids =
            {
                "::FootStone::GrainInterfaces::IZonePush",
                "::Ice::Object"
            };

            public static string ice_staticId()
            {
                return _ids[0];
            }

            #endregion

            #region Marshaling support

            public static void write(Ice.OutputStream ostr, IZonePushPrx v)
            {
                ostr.writeProxy(v);
            }

            public static IZonePushPrx read(Ice.InputStream istr)
            {
                Ice.ObjectPrx proxy = istr.readProxy();
                if(proxy != null)
                {
                    IZonePushPrxHelper result = new IZonePushPrxHelper();
                    result.iceCopyFrom(proxy);
                    return result;
                }
                return null;
            }

            #endregion
        }

        [_System.Runtime.InteropServices.ComVisible(false)]
        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        [_System.Serializable]
        public sealed class IZonePrxHelper : Ice.ObjectPrxHelperBase, IZonePrx
        {
            public IZonePrxHelper()
            {
            }

            public IZonePrxHelper(_System.Runtime.Serialization.SerializationInfo info, _System.Runtime.Serialization.StreamingContext context) : base(info, context)
            {
            }

            #region Synchronous operations

            public void Move(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext())
            {
                try
                {
                    _iceI_MoveAsync(data, context, null, _System.Threading.CancellationToken.None, true).Wait();
                }
                catch(_System.AggregateException ex_)
                {
                    throw ex_.InnerException;
                }
            }

            public void PlayerEnter(string zoneId, Ice.OptionalContext context = new Ice.OptionalContext())
            {
                try
                {
                    _iceI_PlayerEnterAsync(zoneId, context, null, _System.Threading.CancellationToken.None, true).Wait();
                }
                catch(_System.AggregateException ex_)
                {
                    throw ex_.InnerException;
                }
            }

            #endregion

            #region Async Task operations

            public _System.Threading.Tasks.Task MoveAsync(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext(), _System.IProgress<bool> progress = null, _System.Threading.CancellationToken cancel = new _System.Threading.CancellationToken())
            {
                return _iceI_MoveAsync(data, context, progress, cancel, false);
            }

            private _System.Threading.Tasks.Task _iceI_MoveAsync(byte[] iceP_data, Ice.OptionalContext context, _System.IProgress<bool> progress, _System.Threading.CancellationToken cancel, bool synchronous)
            {
                var completed = new IceInternal.OperationTaskCompletionCallback<object>(progress, cancel);
                _iceI_Move(iceP_data, context, synchronous, completed);
                return completed.Task;
            }

            private const string _Move_name = "Move";

            private void _iceI_Move(byte[] iceP_data, _System.Collections.Generic.Dictionary<string, string> context, bool synchronous, IceInternal.OutgoingAsyncCompletionCallback completed)
            {
                var outAsync = getOutgoingAsync<object>(completed);
                outAsync.invoke(
                    _Move_name,
                    Ice.OperationMode.Normal,
                    Ice.FormatType.DefaultFormat,
                    context,
                    synchronous,
                    write: (Ice.OutputStream ostr) =>
                    {
                        BytesHelper.write(ostr, iceP_data);
                    });
            }

            public _System.Threading.Tasks.Task PlayerEnterAsync(string zoneId, Ice.OptionalContext context = new Ice.OptionalContext(), _System.IProgress<bool> progress = null, _System.Threading.CancellationToken cancel = new _System.Threading.CancellationToken())
            {
                return _iceI_PlayerEnterAsync(zoneId, context, progress, cancel, false);
            }

            private _System.Threading.Tasks.Task _iceI_PlayerEnterAsync(string iceP_zoneId, Ice.OptionalContext context, _System.IProgress<bool> progress, _System.Threading.CancellationToken cancel, bool synchronous)
            {
                var completed = new IceInternal.OperationTaskCompletionCallback<object>(progress, cancel);
                _iceI_PlayerEnter(iceP_zoneId, context, synchronous, completed);
                return completed.Task;
            }

            private const string _PlayerEnter_name = "PlayerEnter";

            private void _iceI_PlayerEnter(string iceP_zoneId, _System.Collections.Generic.Dictionary<string, string> context, bool synchronous, IceInternal.OutgoingAsyncCompletionCallback completed)
            {
                var outAsync = getOutgoingAsync<object>(completed);
                outAsync.invoke(
                    _PlayerEnter_name,
                    Ice.OperationMode.Normal,
                    Ice.FormatType.DefaultFormat,
                    context,
                    synchronous,
                    write: (Ice.OutputStream ostr) =>
                    {
                        ostr.writeString(iceP_zoneId);
                    });
            }

            #endregion

            #region Asynchronous operations

            public Ice.AsyncResult<Callback_IZone_Move> begin_Move(byte[] data, Ice.OptionalContext context = new Ice.OptionalContext())
            {
                return begin_Move(data, context, null, null, false);
            }

            public Ice.AsyncResult begin_Move(byte[] data, Ice.AsyncCallback callback, object cookie)
            {
                return begin_Move(data, new Ice.OptionalContext(), callback, cookie, false);
            }

            public Ice.AsyncResult begin_Move(byte[] data, Ice.OptionalContext context, Ice.AsyncCallback callback, object cookie)
            {
                return begin_Move(data, context, callback, cookie, false);
            }

            public void end_Move(Ice.AsyncResult asyncResult)
            {
                var resultI_ = IceInternal.AsyncResultI.check(asyncResult, this, _Move_name);
                ((IceInternal.OutgoingAsyncT<object>)resultI_.OutgoingAsync).getResult(resultI_.wait());
            }

            private Ice.AsyncResult<Callback_IZone_Move> begin_Move(byte[] iceP_data, _System.Collections.Generic.Dictionary<string, string> context, Ice.AsyncCallback completedCallback, object cookie, bool synchronous)
            {
                var completed = new IceInternal.OperationAsyncResultCompletionCallback<Callback_IZone_Move, object>(
                    (Callback_IZone_Move cb, object ret) =>
                    {
                        if(cb != null)
                        {
                            cb.Invoke();
                        }
                    },
                    this, _Move_name, cookie, completedCallback);
                _iceI_Move(iceP_data, context, synchronous, completed);
                return completed;
            }

            public Ice.AsyncResult<Callback_IZone_PlayerEnter> begin_PlayerEnter(string zoneId, Ice.OptionalContext context = new Ice.OptionalContext())
            {
                return begin_PlayerEnter(zoneId, context, null, null, false);
            }

            public Ice.AsyncResult begin_PlayerEnter(string zoneId, Ice.AsyncCallback callback, object cookie)
            {
                return begin_PlayerEnter(zoneId, new Ice.OptionalContext(), callback, cookie, false);
            }

            public Ice.AsyncResult begin_PlayerEnter(string zoneId, Ice.OptionalContext context, Ice.AsyncCallback callback, object cookie)
            {
                return begin_PlayerEnter(zoneId, context, callback, cookie, false);
            }

            public void end_PlayerEnter(Ice.AsyncResult asyncResult)
            {
                var resultI_ = IceInternal.AsyncResultI.check(asyncResult, this, _PlayerEnter_name);
                ((IceInternal.OutgoingAsyncT<object>)resultI_.OutgoingAsync).getResult(resultI_.wait());
            }

            private Ice.AsyncResult<Callback_IZone_PlayerEnter> begin_PlayerEnter(string iceP_zoneId, _System.Collections.Generic.Dictionary<string, string> context, Ice.AsyncCallback completedCallback, object cookie, bool synchronous)
            {
                var completed = new IceInternal.OperationAsyncResultCompletionCallback<Callback_IZone_PlayerEnter, object>(
                    (Callback_IZone_PlayerEnter cb, object ret) =>
                    {
                        if(cb != null)
                        {
                            cb.Invoke();
                        }
                    },
                    this, _PlayerEnter_name, cookie, completedCallback);
                _iceI_PlayerEnter(iceP_zoneId, context, synchronous, completed);
                return completed;
            }

            #endregion

            #region Checked and unchecked cast operations

            public static IZonePrx checkedCast(Ice.ObjectPrx b)
            {
                if(b == null)
                {
                    return null;
                }
                IZonePrx r = b as IZonePrx;
                if((r == null) && b.ice_isA(ice_staticId()))
                {
                    IZonePrxHelper h = new IZonePrxHelper();
                    h.iceCopyFrom(b);
                    r = h;
                }
                return r;
            }

            public static IZonePrx checkedCast(Ice.ObjectPrx b, _System.Collections.Generic.Dictionary<string, string> ctx)
            {
                if(b == null)
                {
                    return null;
                }
                IZonePrx r = b as IZonePrx;
                if((r == null) && b.ice_isA(ice_staticId(), ctx))
                {
                    IZonePrxHelper h = new IZonePrxHelper();
                    h.iceCopyFrom(b);
                    r = h;
                }
                return r;
            }

            public static IZonePrx checkedCast(Ice.ObjectPrx b, string f)
            {
                if(b == null)
                {
                    return null;
                }
                Ice.ObjectPrx bb = b.ice_facet(f);
                try
                {
                    if(bb.ice_isA(ice_staticId()))
                    {
                        IZonePrxHelper h = new IZonePrxHelper();
                        h.iceCopyFrom(bb);
                        return h;
                    }
                }
                catch(Ice.FacetNotExistException)
                {
                }
                return null;
            }

            public static IZonePrx checkedCast(Ice.ObjectPrx b, string f, _System.Collections.Generic.Dictionary<string, string> ctx)
            {
                if(b == null)
                {
                    return null;
                }
                Ice.ObjectPrx bb = b.ice_facet(f);
                try
                {
                    if(bb.ice_isA(ice_staticId(), ctx))
                    {
                        IZonePrxHelper h = new IZonePrxHelper();
                        h.iceCopyFrom(bb);
                        return h;
                    }
                }
                catch(Ice.FacetNotExistException)
                {
                }
                return null;
            }

            public static IZonePrx uncheckedCast(Ice.ObjectPrx b)
            {
                if(b == null)
                {
                    return null;
                }
                IZonePrx r = b as IZonePrx;
                if(r == null)
                {
                    IZonePrxHelper h = new IZonePrxHelper();
                    h.iceCopyFrom(b);
                    r = h;
                }
                return r;
            }

            public static IZonePrx uncheckedCast(Ice.ObjectPrx b, string f)
            {
                if(b == null)
                {
                    return null;
                }
                Ice.ObjectPrx bb = b.ice_facet(f);
                IZonePrxHelper h = new IZonePrxHelper();
                h.iceCopyFrom(bb);
                return h;
            }

            private static readonly string[] _ids =
            {
                "::FootStone::GrainInterfaces::IZone",
                "::Ice::Object"
            };

            public static string ice_staticId()
            {
                return _ids[0];
            }

            #endregion

            #region Marshaling support

            public static void write(Ice.OutputStream ostr, IZonePrx v)
            {
                ostr.writeProxy(v);
            }

            public static IZonePrx read(Ice.InputStream istr)
            {
                Ice.ObjectPrx proxy = istr.readProxy();
                if(proxy != null)
                {
                    IZonePrxHelper result = new IZonePrxHelper();
                    result.iceCopyFrom(proxy);
                    return result;
                }
                return null;
            }

            #endregion
        }
    }
}

namespace FootStone
{
    namespace GrainInterfaces
    {
        [_System.Runtime.InteropServices.ComVisible(false)]
        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public abstract class IZonePushDisp_ : Ice.ObjectImpl, IZonePush
        {
            #region Slice operations

            public abstract void ZoneSync(byte[] data, Ice.Current current = null);

            #endregion

            #region Slice type-related members

            private static readonly string[] _ids =
            {
                "::FootStone::GrainInterfaces::IZonePush",
                "::Ice::Object"
            };

            public override bool ice_isA(string s, Ice.Current current = null)
            {
                return _System.Array.BinarySearch(_ids, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
            }

            public override string[] ice_ids(Ice.Current current = null)
            {
                return _ids;
            }

            public override string ice_id(Ice.Current current = null)
            {
                return _ids[0];
            }

            public static new string ice_staticId()
            {
                return _ids[0];
            }

            #endregion

            #region Operation dispatch

            [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
            public static _System.Threading.Tasks.Task<Ice.OutputStream>
            iceD_ZoneSync(IZonePush obj, IceInternal.Incoming inS, Ice.Current current)
            {
                Ice.ObjectImpl.iceCheckMode(Ice.OperationMode.Normal, current.mode);
                var istr = inS.startReadParams();
                byte[] iceP_data;
                iceP_data = BytesHelper.read(istr);
                inS.endReadParams();
                obj.ZoneSync(iceP_data, current);
                return inS.setResult(inS.writeEmptyParams());
            }

            private static readonly string[] _all =
            {
                "ZoneSync",
                "ice_id",
                "ice_ids",
                "ice_isA",
                "ice_ping"
            };

            public override _System.Threading.Tasks.Task<Ice.OutputStream>
            iceDispatch(IceInternal.Incoming inS, Ice.Current current)
            {
                int pos = _System.Array.BinarySearch(_all, current.operation, IceUtilInternal.StringUtil.OrdinalStringComparer);
                if(pos < 0)
                {
                    throw new Ice.OperationNotExistException(current.id, current.facet, current.operation);
                }

                switch(pos)
                {
                    case 0:
                    {
                        return iceD_ZoneSync(this, inS, current);
                    }
                    case 1:
                    {
                        return Ice.ObjectImpl.iceD_ice_id(this, inS, current);
                    }
                    case 2:
                    {
                        return Ice.ObjectImpl.iceD_ice_ids(this, inS, current);
                    }
                    case 3:
                    {
                        return Ice.ObjectImpl.iceD_ice_isA(this, inS, current);
                    }
                    case 4:
                    {
                        return Ice.ObjectImpl.iceD_ice_ping(this, inS, current);
                    }
                }

                _System.Diagnostics.Debug.Assert(false);
                throw new Ice.OperationNotExistException(current.id, current.facet, current.operation);
            }

            #endregion
        }

        [_System.Runtime.InteropServices.ComVisible(false)]
        [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.1")]
        public abstract class IZoneDisp_ : Ice.ObjectImpl, IZone
        {
            #region Slice operations

            public abstract void PlayerEnter(string zoneId, Ice.Current current = null);

            public abstract void Move(byte[] data, Ice.Current current = null);

            #endregion

            #region Slice type-related members

            private static readonly string[] _ids =
            {
                "::FootStone::GrainInterfaces::IZone",
                "::Ice::Object"
            };

            public override bool ice_isA(string s, Ice.Current current = null)
            {
                return _System.Array.BinarySearch(_ids, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
            }

            public override string[] ice_ids(Ice.Current current = null)
            {
                return _ids;
            }

            public override string ice_id(Ice.Current current = null)
            {
                return _ids[0];
            }

            public static new string ice_staticId()
            {
                return _ids[0];
            }

            #endregion

            #region Operation dispatch

            [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
            public static _System.Threading.Tasks.Task<Ice.OutputStream>
            iceD_PlayerEnter(IZone obj, IceInternal.Incoming inS, Ice.Current current)
            {
                Ice.ObjectImpl.iceCheckMode(Ice.OperationMode.Normal, current.mode);
                var istr = inS.startReadParams();
                string iceP_zoneId;
                iceP_zoneId = istr.readString();
                inS.endReadParams();
                obj.PlayerEnter(iceP_zoneId, current);
                return inS.setResult(inS.writeEmptyParams());
            }

            [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
            public static _System.Threading.Tasks.Task<Ice.OutputStream>
            iceD_Move(IZone obj, IceInternal.Incoming inS, Ice.Current current)
            {
                Ice.ObjectImpl.iceCheckMode(Ice.OperationMode.Normal, current.mode);
                var istr = inS.startReadParams();
                byte[] iceP_data;
                iceP_data = BytesHelper.read(istr);
                inS.endReadParams();
                obj.Move(iceP_data, current);
                return inS.setResult(inS.writeEmptyParams());
            }

            private static readonly string[] _all =
            {
                "Move",
                "PlayerEnter",
                "ice_id",
                "ice_ids",
                "ice_isA",
                "ice_ping"
            };

            public override _System.Threading.Tasks.Task<Ice.OutputStream>
            iceDispatch(IceInternal.Incoming inS, Ice.Current current)
            {
                int pos = _System.Array.BinarySearch(_all, current.operation, IceUtilInternal.StringUtil.OrdinalStringComparer);
                if(pos < 0)
                {
                    throw new Ice.OperationNotExistException(current.id, current.facet, current.operation);
                }

                switch(pos)
                {
                    case 0:
                    {
                        return iceD_Move(this, inS, current);
                    }
                    case 1:
                    {
                        return iceD_PlayerEnter(this, inS, current);
                    }
                    case 2:
                    {
                        return Ice.ObjectImpl.iceD_ice_id(this, inS, current);
                    }
                    case 3:
                    {
                        return Ice.ObjectImpl.iceD_ice_ids(this, inS, current);
                    }
                    case 4:
                    {
                        return Ice.ObjectImpl.iceD_ice_isA(this, inS, current);
                    }
                    case 5:
                    {
                        return Ice.ObjectImpl.iceD_ice_ping(this, inS, current);
                    }
                }

                _System.Diagnostics.Debug.Assert(false);
                throw new Ice.OperationNotExistException(current.id, current.facet, current.operation);
            }

            #endregion
        }
    }
}
