using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFCBCBLFALM : IMessage<IFCBCBLFALM>, IMessage, IEquatable<IFCBCBLFALM>, IDeepCloneable<IFCBCBLFALM>, IBufferMessage
{
	private static readonly MessageParser<IFCBCBLFALM> _parser = new MessageParser<IFCBCBLFALM>(() => new IFCBCBLFALM());

	private UnknownFieldSet _unknownFields;

	public const int KEPENNPINDDFieldNumber = 1;

	private ulong kEPENNPINDD_;

	public const int DELGOCDBEKFFieldNumber = 2;

	private FightGameMode dELGOCDBEKF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFCBCBLFALM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFCBCBLFALMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong KEPENNPINDD
	{
		get
		{
			return kEPENNPINDD_;
		}
		set
		{
			kEPENNPINDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode DELGOCDBEKF
	{
		get
		{
			return dELGOCDBEKF_;
		}
		set
		{
			dELGOCDBEKF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFCBCBLFALM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFCBCBLFALM(IFCBCBLFALM other)
		: this()
	{
		kEPENNPINDD_ = other.kEPENNPINDD_;
		dELGOCDBEKF_ = other.dELGOCDBEKF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFCBCBLFALM Clone()
	{
		return new IFCBCBLFALM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFCBCBLFALM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFCBCBLFALM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KEPENNPINDD != other.KEPENNPINDD)
		{
			return false;
		}
		if (DELGOCDBEKF != other.DELGOCDBEKF)
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
		if (KEPENNPINDD != 0L)
		{
			num ^= KEPENNPINDD.GetHashCode();
		}
		if (DELGOCDBEKF != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= DELGOCDBEKF.GetHashCode();
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
		if (KEPENNPINDD != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(KEPENNPINDD);
		}
		if (DELGOCDBEKF != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DELGOCDBEKF);
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
		if (KEPENNPINDD != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(KEPENNPINDD);
		}
		if (DELGOCDBEKF != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DELGOCDBEKF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFCBCBLFALM other)
	{
		if (other != null)
		{
			if (other.KEPENNPINDD != 0L)
			{
				KEPENNPINDD = other.KEPENNPINDD;
			}
			if (other.DELGOCDBEKF != FightGameMode.EjimiogaoklPcpdhelpkem)
			{
				DELGOCDBEKF = other.DELGOCDBEKF;
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
				KEPENNPINDD = input.ReadUInt64();
				break;
			case 16u:
				DELGOCDBEKF = (FightGameMode)input.ReadEnum();
				break;
			}
		}
	}
}
