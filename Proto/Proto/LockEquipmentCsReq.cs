using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LockEquipmentCsReq : IMessage<LockEquipmentCsReq>, IMessage, IEquatable<LockEquipmentCsReq>, IDeepCloneable<LockEquipmentCsReq>, IBufferMessage
{
	private static readonly MessageParser<LockEquipmentCsReq> _parser = new MessageParser<LockEquipmentCsReq>(() => new LockEquipmentCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IsLockedFieldNumber = 4;

	private bool isLocked_;

	public const int EquipmentIdListFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_equipmentIdList_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> equipmentIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LockEquipmentCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LockEquipmentCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsLocked
	{
		get
		{
			return isLocked_;
		}
		set
		{
			isLocked_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EquipmentIdList => equipmentIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockEquipmentCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockEquipmentCsReq(LockEquipmentCsReq other)
		: this()
	{
		isLocked_ = other.isLocked_;
		equipmentIdList_ = other.equipmentIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockEquipmentCsReq Clone()
	{
		return new LockEquipmentCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LockEquipmentCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LockEquipmentCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsLocked != other.IsLocked)
		{
			return false;
		}
		if (!equipmentIdList_.Equals(other.equipmentIdList_))
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
		if (IsLocked)
		{
			num ^= IsLocked.GetHashCode();
		}
		num ^= equipmentIdList_.GetHashCode();
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
		if (IsLocked)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsLocked);
		}
		equipmentIdList_.WriteTo(ref output, _repeated_equipmentIdList_codec);
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
		if (IsLocked)
		{
			num += 2;
		}
		num += equipmentIdList_.CalculateSize(_repeated_equipmentIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LockEquipmentCsReq other)
	{
		if (other != null)
		{
			if (other.IsLocked)
			{
				IsLocked = other.IsLocked;
			}
			equipmentIdList_.Add(other.equipmentIdList_);
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
				IsLocked = input.ReadBool();
				break;
			case 104u:
			case 106u:
				equipmentIdList_.AddEntriesFrom(ref input, _repeated_equipmentIdList_codec);
				break;
			}
		}
	}
}
