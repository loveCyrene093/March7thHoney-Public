using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicReforgeConfirmCsReq : IMessage<RelicReforgeConfirmCsReq>, IMessage, IEquatable<RelicReforgeConfirmCsReq>, IDeepCloneable<RelicReforgeConfirmCsReq>, IBufferMessage
{
	private static readonly MessageParser<RelicReforgeConfirmCsReq> _parser = new MessageParser<RelicReforgeConfirmCsReq>(() => new RelicReforgeConfirmCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IsCancelFieldNumber = 9;

	private bool isCancel_;

	public const int RelicUniqueIdFieldNumber = 11;

	private uint relicUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicReforgeConfirmCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicReforgeConfirmCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsCancel
	{
		get
		{
			return isCancel_;
		}
		set
		{
			isCancel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RelicUniqueId
	{
		get
		{
			return relicUniqueId_;
		}
		set
		{
			relicUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicReforgeConfirmCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicReforgeConfirmCsReq(RelicReforgeConfirmCsReq other)
		: this()
	{
		isCancel_ = other.isCancel_;
		relicUniqueId_ = other.relicUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicReforgeConfirmCsReq Clone()
	{
		return new RelicReforgeConfirmCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicReforgeConfirmCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicReforgeConfirmCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsCancel != other.IsCancel)
		{
			return false;
		}
		if (RelicUniqueId != other.RelicUniqueId)
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
		if (IsCancel)
		{
			num ^= IsCancel.GetHashCode();
		}
		if (RelicUniqueId != 0)
		{
			num ^= RelicUniqueId.GetHashCode();
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
		if (IsCancel)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsCancel);
		}
		if (RelicUniqueId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(RelicUniqueId);
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
		if (IsCancel)
		{
			num += 2;
		}
		if (RelicUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RelicUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicReforgeConfirmCsReq other)
	{
		if (other != null)
		{
			if (other.IsCancel)
			{
				IsCancel = other.IsCancel;
			}
			if (other.RelicUniqueId != 0)
			{
				RelicUniqueId = other.RelicUniqueId;
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
			case 72u:
				IsCancel = input.ReadBool();
				break;
			case 88u:
				RelicUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
