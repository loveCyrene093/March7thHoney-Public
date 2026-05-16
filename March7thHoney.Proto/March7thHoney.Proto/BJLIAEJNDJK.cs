using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BJLIAEJNDJK : IMessage<BJLIAEJNDJK>, IMessage, IEquatable<BJLIAEJNDJK>, IDeepCloneable<BJLIAEJNDJK>, IBufferMessage
{
	public enum EAGNHMILECNOneofCase
	{
		None = 0,
		JPOKEADJNPI = 8,
		ExtraId = 13
	}

	private static readonly MessageParser<BJLIAEJNDJK> _parser = new MessageParser<BJLIAEJNDJK>(() => new BJLIAEJNDJK());

	private UnknownFieldSet _unknownFields;

	public const int JPOKEADJNPIFieldNumber = 8;

	public const int ExtraIdFieldNumber = 13;

	private object eAGNHMILECN_;

	private EAGNHMILECNOneofCase eAGNHMILECNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BJLIAEJNDJK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BJLIAEJNDJKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JPOKEADJNPI
	{
		get
		{
			if (!HasJPOKEADJNPI)
			{
				return 0u;
			}
			return (uint)eAGNHMILECN_;
		}
		set
		{
			eAGNHMILECN_ = value;
			eAGNHMILECNCase_ = EAGNHMILECNOneofCase.JPOKEADJNPI;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJPOKEADJNPI => eAGNHMILECNCase_ == EAGNHMILECNOneofCase.JPOKEADJNPI;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExtraId
	{
		get
		{
			if (!HasExtraId)
			{
				return 0u;
			}
			return (uint)eAGNHMILECN_;
		}
		set
		{
			eAGNHMILECN_ = value;
			eAGNHMILECNCase_ = EAGNHMILECNOneofCase.ExtraId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasExtraId => eAGNHMILECNCase_ == EAGNHMILECNOneofCase.ExtraId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EAGNHMILECNOneofCase EAGNHMILECNCase => eAGNHMILECNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJLIAEJNDJK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJLIAEJNDJK(BJLIAEJNDJK other)
		: this()
	{
		switch (other.EAGNHMILECNCase)
		{
		case EAGNHMILECNOneofCase.JPOKEADJNPI:
			JPOKEADJNPI = other.JPOKEADJNPI;
			break;
		case EAGNHMILECNOneofCase.ExtraId:
			ExtraId = other.ExtraId;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJLIAEJNDJK Clone()
	{
		return new BJLIAEJNDJK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJPOKEADJNPI()
	{
		if (HasJPOKEADJNPI)
		{
			ClearEAGNHMILECN();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearExtraId()
	{
		if (HasExtraId)
		{
			ClearEAGNHMILECN();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEAGNHMILECN()
	{
		eAGNHMILECNCase_ = EAGNHMILECNOneofCase.None;
		eAGNHMILECN_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BJLIAEJNDJK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BJLIAEJNDJK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JPOKEADJNPI != other.JPOKEADJNPI)
		{
			return false;
		}
		if (ExtraId != other.ExtraId)
		{
			return false;
		}
		if (EAGNHMILECNCase != other.EAGNHMILECNCase)
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
		if (HasJPOKEADJNPI)
		{
			num ^= JPOKEADJNPI.GetHashCode();
		}
		if (HasExtraId)
		{
			num ^= ExtraId.GetHashCode();
		}
		num ^= (int)eAGNHMILECNCase_;
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
		if (HasJPOKEADJNPI)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(JPOKEADJNPI);
		}
		if (HasExtraId)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ExtraId);
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
		if (HasJPOKEADJNPI)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JPOKEADJNPI);
		}
		if (HasExtraId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ExtraId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BJLIAEJNDJK other)
	{
		if (other != null)
		{
			switch (other.EAGNHMILECNCase)
			{
			case EAGNHMILECNOneofCase.JPOKEADJNPI:
				JPOKEADJNPI = other.JPOKEADJNPI;
				break;
			case EAGNHMILECNOneofCase.ExtraId:
				ExtraId = other.ExtraId;
				break;
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
			case 64u:
				JPOKEADJNPI = input.ReadUInt32();
				break;
			case 104u:
				ExtraId = input.ReadUInt32();
				break;
			}
		}
	}
}
