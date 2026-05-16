using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EKGAMNCMOEJ : IMessage<EKGAMNCMOEJ>, IMessage, IEquatable<EKGAMNCMOEJ>, IDeepCloneable<EKGAMNCMOEJ>, IBufferMessage
{
	private static readonly MessageParser<EKGAMNCMOEJ> _parser = new MessageParser<EKGAMNCMOEJ>(() => new EKGAMNCMOEJ());

	private UnknownFieldSet _unknownFields;

	public const int DFLMKCIKFOPFieldNumber = 3;

	private string dFLMKCIKFOP_ = "";

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int StageIdFieldNumber = 11;

	private uint stageId_;

	public const int ReplayTypeFieldNumber = 13;

	private OCLEJLEFBFO replayType_;

	public const int EFLAEANKACMFieldNumber = 14;

	private string eFLAEANKACM_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EKGAMNCMOEJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EKGAMNCMOEJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DFLMKCIKFOP
	{
		get
		{
			return dFLMKCIKFOP_;
		}
		set
		{
			dFLMKCIKFOP_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OCLEJLEFBFO ReplayType
	{
		get
		{
			return replayType_;
		}
		set
		{
			replayType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EFLAEANKACM
	{
		get
		{
			return eFLAEANKACM_;
		}
		set
		{
			eFLAEANKACM_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKGAMNCMOEJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKGAMNCMOEJ(EKGAMNCMOEJ other)
		: this()
	{
		dFLMKCIKFOP_ = other.dFLMKCIKFOP_;
		retcode_ = other.retcode_;
		stageId_ = other.stageId_;
		replayType_ = other.replayType_;
		eFLAEANKACM_ = other.eFLAEANKACM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKGAMNCMOEJ Clone()
	{
		return new EKGAMNCMOEJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EKGAMNCMOEJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EKGAMNCMOEJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DFLMKCIKFOP != other.DFLMKCIKFOP)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (ReplayType != other.ReplayType)
		{
			return false;
		}
		if (EFLAEANKACM != other.EFLAEANKACM)
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
		if (DFLMKCIKFOP.Length != 0)
		{
			num ^= DFLMKCIKFOP.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
		{
			num ^= ReplayType.GetHashCode();
		}
		if (EFLAEANKACM.Length != 0)
		{
			num ^= EFLAEANKACM.GetHashCode();
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
		if (DFLMKCIKFOP.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(DFLMKCIKFOP);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(StageId);
		}
		if (ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)ReplayType);
		}
		if (EFLAEANKACM.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(EFLAEANKACM);
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
		if (DFLMKCIKFOP.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DFLMKCIKFOP);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ReplayType);
		}
		if (EFLAEANKACM.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EFLAEANKACM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EKGAMNCMOEJ other)
	{
		if (other != null)
		{
			if (other.DFLMKCIKFOP.Length != 0)
			{
				DFLMKCIKFOP = other.DFLMKCIKFOP;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
			{
				ReplayType = other.ReplayType;
			}
			if (other.EFLAEANKACM.Length != 0)
			{
				EFLAEANKACM = other.EFLAEANKACM;
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
			case 26u:
				DFLMKCIKFOP = input.ReadString();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				StageId = input.ReadUInt32();
				break;
			case 104u:
				ReplayType = (OCLEJLEFBFO)input.ReadEnum();
				break;
			case 114u:
				EFLAEANKACM = input.ReadString();
				break;
			}
		}
	}
}
