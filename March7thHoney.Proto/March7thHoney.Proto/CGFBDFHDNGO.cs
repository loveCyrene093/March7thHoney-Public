using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGFBDFHDNGO : IMessage<CGFBDFHDNGO>, IMessage, IEquatable<CGFBDFHDNGO>, IDeepCloneable<CGFBDFHDNGO>, IBufferMessage
{
	private static readonly MessageParser<CGFBDFHDNGO> _parser = new MessageParser<CGFBDFHDNGO>(() => new CGFBDFHDNGO());

	private UnknownFieldSet _unknownFields;

	public const int AFPELFMPICIFieldNumber = 2;

	private uint aFPELFMPICI_;

	public const int LKMGNCBOOKDFieldNumber = 5;

	private uint lKMGNCBOOKD_;

	public const int UidFieldNumber = 13;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGFBDFHDNGO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGFBDFHDNGOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFPELFMPICI
	{
		get
		{
			return aFPELFMPICI_;
		}
		set
		{
			aFPELFMPICI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LKMGNCBOOKD
	{
		get
		{
			return lKMGNCBOOKD_;
		}
		set
		{
			lKMGNCBOOKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGFBDFHDNGO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGFBDFHDNGO(CGFBDFHDNGO other)
		: this()
	{
		aFPELFMPICI_ = other.aFPELFMPICI_;
		lKMGNCBOOKD_ = other.lKMGNCBOOKD_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGFBDFHDNGO Clone()
	{
		return new CGFBDFHDNGO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGFBDFHDNGO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGFBDFHDNGO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AFPELFMPICI != other.AFPELFMPICI)
		{
			return false;
		}
		if (LKMGNCBOOKD != other.LKMGNCBOOKD)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		if (AFPELFMPICI != 0)
		{
			num ^= AFPELFMPICI.GetHashCode();
		}
		if (LKMGNCBOOKD != 0)
		{
			num ^= LKMGNCBOOKD.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		if (AFPELFMPICI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(AFPELFMPICI);
		}
		if (LKMGNCBOOKD != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LKMGNCBOOKD);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Uid);
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
		if (AFPELFMPICI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFPELFMPICI);
		}
		if (LKMGNCBOOKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LKMGNCBOOKD);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CGFBDFHDNGO other)
	{
		if (other != null)
		{
			if (other.AFPELFMPICI != 0)
			{
				AFPELFMPICI = other.AFPELFMPICI;
			}
			if (other.LKMGNCBOOKD != 0)
			{
				LKMGNCBOOKD = other.LKMGNCBOOKD;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
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
				AFPELFMPICI = input.ReadUInt32();
				break;
			case 40u:
				LKMGNCBOOKD = input.ReadUInt32();
				break;
			case 104u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
