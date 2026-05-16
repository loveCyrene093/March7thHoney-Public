using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TechTreeChangeNodeStateCsRsp : IMessage<TechTreeChangeNodeStateCsRsp>, IMessage, IEquatable<TechTreeChangeNodeStateCsRsp>, IDeepCloneable<TechTreeChangeNodeStateCsRsp>, IBufferMessage
{
	private static readonly MessageParser<TechTreeChangeNodeStateCsRsp> _parser = new MessageParser<TechTreeChangeNodeStateCsRsp>(() => new TechTreeChangeNodeStateCsRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int OpTypeFieldNumber = 5;

	private JDKJPFGJOBI opType_;

	public const int NLGNAKKCDGOFieldNumber = 6;

	private uint nLGNAKKCDGO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TechTreeChangeNodeStateCsRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TechTreeChangeNodeStateCsRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public JDKJPFGJOBI OpType
	{
		get
		{
			return opType_;
		}
		set
		{
			opType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLGNAKKCDGO
	{
		get
		{
			return nLGNAKKCDGO_;
		}
		set
		{
			nLGNAKKCDGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TechTreeChangeNodeStateCsRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TechTreeChangeNodeStateCsRsp(TechTreeChangeNodeStateCsRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		opType_ = other.opType_;
		nLGNAKKCDGO_ = other.nLGNAKKCDGO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TechTreeChangeNodeStateCsRsp Clone()
	{
		return new TechTreeChangeNodeStateCsRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TechTreeChangeNodeStateCsRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TechTreeChangeNodeStateCsRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (OpType != other.OpType)
		{
			return false;
		}
		if (NLGNAKKCDGO != other.NLGNAKKCDGO)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (OpType != JDKJPFGJOBI.Pcpdhelpkem)
		{
			num ^= OpType.GetHashCode();
		}
		if (NLGNAKKCDGO != 0)
		{
			num ^= NLGNAKKCDGO.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (OpType != JDKJPFGJOBI.Pcpdhelpkem)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)OpType);
		}
		if (NLGNAKKCDGO != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(NLGNAKKCDGO);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (OpType != JDKJPFGJOBI.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OpType);
		}
		if (NLGNAKKCDGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLGNAKKCDGO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TechTreeChangeNodeStateCsRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.OpType != JDKJPFGJOBI.Pcpdhelpkem)
			{
				OpType = other.OpType;
			}
			if (other.NLGNAKKCDGO != 0)
			{
				NLGNAKKCDGO = other.NLGNAKKCDGO;
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				OpType = (JDKJPFGJOBI)input.ReadEnum();
				break;
			case 48u:
				NLGNAKKCDGO = input.ReadUInt32();
				break;
			}
		}
	}
}
