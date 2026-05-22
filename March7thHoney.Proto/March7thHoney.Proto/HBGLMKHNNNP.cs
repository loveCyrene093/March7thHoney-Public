using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HBGLMKHNNNP : IMessage<HBGLMKHNNNP>, IMessage, IEquatable<HBGLMKHNNNP>, IDeepCloneable<HBGLMKHNNNP>, IBufferMessage
{
	private static readonly MessageParser<HBGLMKHNNNP> _parser = new MessageParser<HBGLMKHNNNP>(() => new HBGLMKHNNNP());

	private UnknownFieldSet _unknownFields;

	public const int LBPLNLDHCBOFieldNumber = 6;

	private bool lBPLNLDHCBO_;

	public const int GPJHJOOIJJCFieldNumber = 9;

	private uint gPJHJOOIJJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HBGLMKHNNNP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HBGLMKHNNNPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LBPLNLDHCBO
	{
		get
		{
			return lBPLNLDHCBO_;
		}
		set
		{
			lBPLNLDHCBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPJHJOOIJJC
	{
		get
		{
			return gPJHJOOIJJC_;
		}
		set
		{
			gPJHJOOIJJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBGLMKHNNNP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBGLMKHNNNP(HBGLMKHNNNP other)
		: this()
	{
		lBPLNLDHCBO_ = other.lBPLNLDHCBO_;
		gPJHJOOIJJC_ = other.gPJHJOOIJJC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HBGLMKHNNNP Clone()
	{
		return new HBGLMKHNNNP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HBGLMKHNNNP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HBGLMKHNNNP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LBPLNLDHCBO != other.LBPLNLDHCBO)
		{
			return false;
		}
		if (GPJHJOOIJJC != other.GPJHJOOIJJC)
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
		if (LBPLNLDHCBO)
		{
			num ^= LBPLNLDHCBO.GetHashCode();
		}
		if (GPJHJOOIJJC != 0)
		{
			num ^= GPJHJOOIJJC.GetHashCode();
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
		if (LBPLNLDHCBO)
		{
			output.WriteRawTag(48);
			output.WriteBool(LBPLNLDHCBO);
		}
		if (GPJHJOOIJJC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GPJHJOOIJJC);
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
		if (LBPLNLDHCBO)
		{
			num += 2;
		}
		if (GPJHJOOIJJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPJHJOOIJJC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HBGLMKHNNNP other)
	{
		if (other != null)
		{
			if (other.LBPLNLDHCBO)
			{
				LBPLNLDHCBO = other.LBPLNLDHCBO;
			}
			if (other.GPJHJOOIJJC != 0)
			{
				GPJHJOOIJJC = other.GPJHJOOIJJC;
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
			case 48u:
				LBPLNLDHCBO = input.ReadBool();
				break;
			case 72u:
				GPJHJOOIJJC = input.ReadUInt32();
				break;
			}
		}
	}
}
