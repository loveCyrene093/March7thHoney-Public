using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlleyPlacingGameScRsp : IMessage<AlleyPlacingGameScRsp>, IMessage, IEquatable<AlleyPlacingGameScRsp>, IDeepCloneable<AlleyPlacingGameScRsp>, IBufferMessage
{
	private static readonly MessageParser<AlleyPlacingGameScRsp> _parser = new MessageParser<AlleyPlacingGameScRsp>(() => new AlleyPlacingGameScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GKOAHBKEDHLFieldNumber = 1;

	private uint gKOAHBKEDHL_;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int HGIFEKEFCANFieldNumber = 5;

	private uint hGIFEKEFCAN_;

	public const int AHNPMGLOIEHFieldNumber = 6;

	private uint aHNPMGLOIEH_;

	public const int KHEBCOPEGKCFieldNumber = 10;

	private uint kHEBCOPEGKC_;

	public const int MABFDBCDCDNFieldNumber = 11;

	private uint mABFDBCDCDN_;

	public const int EventIdFieldNumber = 13;

	private uint eventId_;

	public const int LDLOJJGNJMJFieldNumber = 14;

	private uint lDLOJJGNJMJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlleyPlacingGameScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AlleyPlacingGameScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKOAHBKEDHL
	{
		get
		{
			return gKOAHBKEDHL_;
		}
		set
		{
			gKOAHBKEDHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HGIFEKEFCAN
	{
		get
		{
			return hGIFEKEFCAN_;
		}
		set
		{
			hGIFEKEFCAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHNPMGLOIEH
	{
		get
		{
			return aHNPMGLOIEH_;
		}
		set
		{
			aHNPMGLOIEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHEBCOPEGKC
	{
		get
		{
			return kHEBCOPEGKC_;
		}
		set
		{
			kHEBCOPEGKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MABFDBCDCDN
	{
		get
		{
			return mABFDBCDCDN_;
		}
		set
		{
			mABFDBCDCDN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDLOJJGNJMJ
	{
		get
		{
			return lDLOJJGNJMJ_;
		}
		set
		{
			lDLOJJGNJMJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingGameScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingGameScRsp(AlleyPlacingGameScRsp other)
		: this()
	{
		gKOAHBKEDHL_ = other.gKOAHBKEDHL_;
		retcode_ = other.retcode_;
		hGIFEKEFCAN_ = other.hGIFEKEFCAN_;
		aHNPMGLOIEH_ = other.aHNPMGLOIEH_;
		kHEBCOPEGKC_ = other.kHEBCOPEGKC_;
		mABFDBCDCDN_ = other.mABFDBCDCDN_;
		eventId_ = other.eventId_;
		lDLOJJGNJMJ_ = other.lDLOJJGNJMJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingGameScRsp Clone()
	{
		return new AlleyPlacingGameScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AlleyPlacingGameScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlleyPlacingGameScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GKOAHBKEDHL != other.GKOAHBKEDHL)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (HGIFEKEFCAN != other.HGIFEKEFCAN)
		{
			return false;
		}
		if (AHNPMGLOIEH != other.AHNPMGLOIEH)
		{
			return false;
		}
		if (KHEBCOPEGKC != other.KHEBCOPEGKC)
		{
			return false;
		}
		if (MABFDBCDCDN != other.MABFDBCDCDN)
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (LDLOJJGNJMJ != other.LDLOJJGNJMJ)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (GKOAHBKEDHL != 0)
		{
			num ^= GKOAHBKEDHL.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (HGIFEKEFCAN != 0)
		{
			num ^= HGIFEKEFCAN.GetHashCode();
		}
		if (AHNPMGLOIEH != 0)
		{
			num ^= AHNPMGLOIEH.GetHashCode();
		}
		if (KHEBCOPEGKC != 0)
		{
			num ^= KHEBCOPEGKC.GetHashCode();
		}
		if (MABFDBCDCDN != 0)
		{
			num ^= MABFDBCDCDN.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (LDLOJJGNJMJ != 0)
		{
			num ^= LDLOJJGNJMJ.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (GKOAHBKEDHL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(GKOAHBKEDHL);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (HGIFEKEFCAN != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HGIFEKEFCAN);
		}
		if (AHNPMGLOIEH != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AHNPMGLOIEH);
		}
		if (KHEBCOPEGKC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(KHEBCOPEGKC);
		}
		if (MABFDBCDCDN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MABFDBCDCDN);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(EventId);
		}
		if (LDLOJJGNJMJ != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LDLOJJGNJMJ);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (GKOAHBKEDHL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKOAHBKEDHL);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (HGIFEKEFCAN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HGIFEKEFCAN);
		}
		if (AHNPMGLOIEH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHNPMGLOIEH);
		}
		if (KHEBCOPEGKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHEBCOPEGKC);
		}
		if (MABFDBCDCDN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MABFDBCDCDN);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (LDLOJJGNJMJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDLOJJGNJMJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlleyPlacingGameScRsp other)
	{
		if (other != null)
		{
			if (other.GKOAHBKEDHL != 0)
			{
				GKOAHBKEDHL = other.GKOAHBKEDHL;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.HGIFEKEFCAN != 0)
			{
				HGIFEKEFCAN = other.HGIFEKEFCAN;
			}
			if (other.AHNPMGLOIEH != 0)
			{
				AHNPMGLOIEH = other.AHNPMGLOIEH;
			}
			if (other.KHEBCOPEGKC != 0)
			{
				KHEBCOPEGKC = other.KHEBCOPEGKC;
			}
			if (other.MABFDBCDCDN != 0)
			{
				MABFDBCDCDN = other.MABFDBCDCDN;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.LDLOJJGNJMJ != 0)
			{
				LDLOJJGNJMJ = other.LDLOJJGNJMJ;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				GKOAHBKEDHL = input.ReadUInt32();
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				HGIFEKEFCAN = input.ReadUInt32();
				break;
			case 48u:
				AHNPMGLOIEH = input.ReadUInt32();
				break;
			case 80u:
				KHEBCOPEGKC = input.ReadUInt32();
				break;
			case 88u:
				MABFDBCDCDN = input.ReadUInt32();
				break;
			case 104u:
				EventId = input.ReadUInt32();
				break;
			case 112u:
				LDLOJJGNJMJ = input.ReadUInt32();
				break;
			}
		}
	}
}
