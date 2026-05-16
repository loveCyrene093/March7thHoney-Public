using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HDNOFFGMDNJ : IMessage<HDNOFFGMDNJ>, IMessage, IEquatable<HDNOFFGMDNJ>, IDeepCloneable<HDNOFFGMDNJ>, IBufferMessage
{
	private static readonly MessageParser<HDNOFFGMDNJ> _parser = new MessageParser<HDNOFFGMDNJ>(() => new HDNOFFGMDNJ());

	private UnknownFieldSet _unknownFields;

	public const int NOOJOLKILFBFieldNumber = 4;

	private uint nOOJOLKILFB_;

	public const int KPNFNMIDFCKFieldNumber = 6;

	private uint kPNFNMIDFCK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HDNOFFGMDNJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HDNOFFGMDNJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NOOJOLKILFB
	{
		get
		{
			return nOOJOLKILFB_;
		}
		set
		{
			nOOJOLKILFB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPNFNMIDFCK
	{
		get
		{
			return kPNFNMIDFCK_;
		}
		set
		{
			kPNFNMIDFCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDNOFFGMDNJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDNOFFGMDNJ(HDNOFFGMDNJ other)
		: this()
	{
		nOOJOLKILFB_ = other.nOOJOLKILFB_;
		kPNFNMIDFCK_ = other.kPNFNMIDFCK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDNOFFGMDNJ Clone()
	{
		return new HDNOFFGMDNJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HDNOFFGMDNJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HDNOFFGMDNJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NOOJOLKILFB != other.NOOJOLKILFB)
		{
			return false;
		}
		if (KPNFNMIDFCK != other.KPNFNMIDFCK)
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
		if (NOOJOLKILFB != 0)
		{
			num ^= NOOJOLKILFB.GetHashCode();
		}
		if (KPNFNMIDFCK != 0)
		{
			num ^= KPNFNMIDFCK.GetHashCode();
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
		if (NOOJOLKILFB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NOOJOLKILFB);
		}
		if (KPNFNMIDFCK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KPNFNMIDFCK);
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
		if (NOOJOLKILFB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NOOJOLKILFB);
		}
		if (KPNFNMIDFCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPNFNMIDFCK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HDNOFFGMDNJ other)
	{
		if (other != null)
		{
			if (other.NOOJOLKILFB != 0)
			{
				NOOJOLKILFB = other.NOOJOLKILFB;
			}
			if (other.KPNFNMIDFCK != 0)
			{
				KPNFNMIDFCK = other.KPNFNMIDFCK;
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
			case 32u:
				NOOJOLKILFB = input.ReadUInt32();
				break;
			case 48u:
				KPNFNMIDFCK = input.ReadUInt32();
				break;
			}
		}
	}
}
