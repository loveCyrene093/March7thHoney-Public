using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournStartScRsp : IMessage<RogueTournStartScRsp>, IMessage, IEquatable<RogueTournStartScRsp>, IDeepCloneable<RogueTournStartScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournStartScRsp> _parser = new MessageParser<RogueTournStartScRsp>(() => new RogueTournStartScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IPOHLJBLKOAFieldNumber = 1;

	private uint iPOHLJBLKOA_;

	public const int AFLJJJFCBINFieldNumber = 5;

	private BFEIPELFCDF aFLJJJFCBIN_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int HHDLEADBJGNFieldNumber = 15;

	private APMHDGPDGNP hHDLEADBJGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournStartScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournStartScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPOHLJBLKOA
	{
		get
		{
			return iPOHLJBLKOA_;
		}
		set
		{
			iPOHLJBLKOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFEIPELFCDF AFLJJJFCBIN
	{
		get
		{
			return aFLJJJFCBIN_;
		}
		set
		{
			aFLJJJFCBIN_ = value;
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
	public APMHDGPDGNP HHDLEADBJGN
	{
		get
		{
			return hHDLEADBJGN_;
		}
		set
		{
			hHDLEADBJGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournStartScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournStartScRsp(RogueTournStartScRsp other)
		: this()
	{
		iPOHLJBLKOA_ = other.iPOHLJBLKOA_;
		aFLJJJFCBIN_ = ((other.aFLJJJFCBIN_ != null) ? other.aFLJJJFCBIN_.Clone() : null);
		retcode_ = other.retcode_;
		hHDLEADBJGN_ = ((other.hHDLEADBJGN_ != null) ? other.hHDLEADBJGN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournStartScRsp Clone()
	{
		return new RogueTournStartScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournStartScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournStartScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IPOHLJBLKOA != other.IPOHLJBLKOA)
		{
			return false;
		}
		if (!object.Equals(AFLJJJFCBIN, other.AFLJJJFCBIN))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(HHDLEADBJGN, other.HHDLEADBJGN))
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
		if (IPOHLJBLKOA != 0)
		{
			num ^= IPOHLJBLKOA.GetHashCode();
		}
		if (aFLJJJFCBIN_ != null)
		{
			num ^= AFLJJJFCBIN.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (hHDLEADBJGN_ != null)
		{
			num ^= HHDLEADBJGN.GetHashCode();
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
		if (IPOHLJBLKOA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IPOHLJBLKOA);
		}
		if (aFLJJJFCBIN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(AFLJJJFCBIN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (hHDLEADBJGN_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(HHDLEADBJGN);
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
		if (IPOHLJBLKOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPOHLJBLKOA);
		}
		if (aFLJJJFCBIN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFLJJJFCBIN);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (hHDLEADBJGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HHDLEADBJGN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournStartScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IPOHLJBLKOA != 0)
		{
			IPOHLJBLKOA = other.IPOHLJBLKOA;
		}
		if (other.aFLJJJFCBIN_ != null)
		{
			if (aFLJJJFCBIN_ == null)
			{
				AFLJJJFCBIN = new BFEIPELFCDF();
			}
			AFLJJJFCBIN.MergeFrom(other.AFLJJJFCBIN);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.hHDLEADBJGN_ != null)
		{
			if (hHDLEADBJGN_ == null)
			{
				HHDLEADBJGN = new APMHDGPDGNP();
			}
			HHDLEADBJGN.MergeFrom(other.HHDLEADBJGN);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				IPOHLJBLKOA = input.ReadUInt32();
				break;
			case 42u:
				if (aFLJJJFCBIN_ == null)
				{
					AFLJJJFCBIN = new BFEIPELFCDF();
				}
				input.ReadMessage(AFLJJJFCBIN);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				if (hHDLEADBJGN_ == null)
				{
					HHDLEADBJGN = new APMHDGPDGNP();
				}
				input.ReadMessage(HHDLEADBJGN);
				break;
			}
		}
	}
}
