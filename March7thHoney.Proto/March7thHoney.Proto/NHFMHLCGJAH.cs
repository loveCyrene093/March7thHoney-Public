using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NHFMHLCGJAH : IMessage<NHFMHLCGJAH>, IMessage, IEquatable<NHFMHLCGJAH>, IDeepCloneable<NHFMHLCGJAH>, IBufferMessage
{
	private static readonly MessageParser<NHFMHLCGJAH> _parser = new MessageParser<NHFMHLCGJAH>(() => new NHFMHLCGJAH());

	private UnknownFieldSet _unknownFields;

	public const int GCPNCEDAMABFieldNumber = 2;

	private uint gCPNCEDAMAB_;

	public const int MHECOFPGECBFieldNumber = 15;

	private uint mHECOFPGECB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NHFMHLCGJAH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NHFMHLCGJAHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCPNCEDAMAB
	{
		get
		{
			return gCPNCEDAMAB_;
		}
		set
		{
			gCPNCEDAMAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MHECOFPGECB
	{
		get
		{
			return mHECOFPGECB_;
		}
		set
		{
			mHECOFPGECB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHFMHLCGJAH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHFMHLCGJAH(NHFMHLCGJAH other)
		: this()
	{
		gCPNCEDAMAB_ = other.gCPNCEDAMAB_;
		mHECOFPGECB_ = other.mHECOFPGECB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHFMHLCGJAH Clone()
	{
		return new NHFMHLCGJAH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NHFMHLCGJAH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NHFMHLCGJAH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GCPNCEDAMAB != other.GCPNCEDAMAB)
		{
			return false;
		}
		if (MHECOFPGECB != other.MHECOFPGECB)
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
		if (GCPNCEDAMAB != 0)
		{
			num ^= GCPNCEDAMAB.GetHashCode();
		}
		if (MHECOFPGECB != 0)
		{
			num ^= MHECOFPGECB.GetHashCode();
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
		if (GCPNCEDAMAB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GCPNCEDAMAB);
		}
		if (MHECOFPGECB != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MHECOFPGECB);
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
		if (GCPNCEDAMAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCPNCEDAMAB);
		}
		if (MHECOFPGECB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MHECOFPGECB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NHFMHLCGJAH other)
	{
		if (other != null)
		{
			if (other.GCPNCEDAMAB != 0)
			{
				GCPNCEDAMAB = other.GCPNCEDAMAB;
			}
			if (other.MHECOFPGECB != 0)
			{
				MHECOFPGECB = other.MHECOFPGECB;
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
			case 16u:
				GCPNCEDAMAB = input.ReadUInt32();
				break;
			case 120u:
				MHECOFPGECB = input.ReadUInt32();
				break;
			}
		}
	}
}
