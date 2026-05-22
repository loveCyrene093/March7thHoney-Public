using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicPresetUpdatePlanCsReq : IMessage<RelicPresetUpdatePlanCsReq>, IMessage, IEquatable<RelicPresetUpdatePlanCsReq>, IDeepCloneable<RelicPresetUpdatePlanCsReq>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		RelicList = 3,
		Name = 14
	}

	private static readonly MessageParser<RelicPresetUpdatePlanCsReq> _parser = new MessageParser<RelicPresetUpdatePlanCsReq>(() => new RelicPresetUpdatePlanCsReq());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 10;

	private uint uniqueId_;

	public const int RelicListFieldNumber = 3;

	public const int NameFieldNumber = 14;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicPresetUpdatePlanCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicPresetUpdatePlanCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPDDLAOBMBH RelicList
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.RelicList)
			{
				return null;
			}
			return (DPDDLAOBMBH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.RelicList : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get
		{
			if (!HasName)
			{
				return "";
			}
			return (string)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = ProtoPreconditions.CheckNotNull(value, "value");
			bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.Name;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasName => bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.Name;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicPresetUpdatePlanCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicPresetUpdatePlanCsReq(RelicPresetUpdatePlanCsReq other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.RelicList:
			RelicList = other.RelicList.Clone();
			break;
		case BPIHFAJCLOCOneofCase.Name:
			Name = other.Name;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicPresetUpdatePlanCsReq Clone()
	{
		return new RelicPresetUpdatePlanCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearName()
	{
		if (HasName)
		{
			ClearBPIHFAJCLOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicPresetUpdatePlanCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicPresetUpdatePlanCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(RelicList, other.RelicList))
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RelicList)
		{
			num ^= RelicList.GetHashCode();
		}
		if (HasName)
		{
			num ^= Name.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RelicList)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RelicList);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(UniqueId);
		}
		if (HasName)
		{
			output.WriteRawTag(114);
			output.WriteString(Name);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RelicList)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RelicList);
		}
		if (HasName)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicPresetUpdatePlanCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.RelicList:
			if (RelicList == null)
			{
				RelicList = new DPDDLAOBMBH();
			}
			RelicList.MergeFrom(other.RelicList);
			break;
		case BPIHFAJCLOCOneofCase.Name:
			Name = other.Name;
			break;
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
			case 26u:
			{
				DPDDLAOBMBH dPDDLAOBMBH = new DPDDLAOBMBH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RelicList)
				{
					dPDDLAOBMBH.MergeFrom(RelicList);
				}
				input.ReadMessage(dPDDLAOBMBH);
				RelicList = dPDDLAOBMBH;
				break;
			}
			case 80u:
				UniqueId = input.ReadUInt32();
				break;
			case 114u:
				Name = input.ReadString();
				break;
			}
		}
	}
}
