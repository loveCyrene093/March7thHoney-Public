using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightRecommendEquipmentActionResult : IMessage<GridFightRecommendEquipmentActionResult>, IMessage, IEquatable<GridFightRecommendEquipmentActionResult>, IDeepCloneable<GridFightRecommendEquipmentActionResult>, IBufferMessage
{
	private static readonly MessageParser<GridFightRecommendEquipmentActionResult> _parser = new MessageParser<GridFightRecommendEquipmentActionResult>(() => new GridFightRecommendEquipmentActionResult());

	private UnknownFieldSet _unknownFields;

	public const int SelectEquipmentIdFieldNumber = 7;

	private uint selectEquipmentId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightRecommendEquipmentActionResult> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightRecommendEquipmentActionResultReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SelectEquipmentId
	{
		get
		{
			return selectEquipmentId_;
		}
		set
		{
			selectEquipmentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRecommendEquipmentActionResult()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRecommendEquipmentActionResult(GridFightRecommendEquipmentActionResult other)
		: this()
	{
		selectEquipmentId_ = other.selectEquipmentId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRecommendEquipmentActionResult Clone()
	{
		return new GridFightRecommendEquipmentActionResult(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightRecommendEquipmentActionResult);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightRecommendEquipmentActionResult other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SelectEquipmentId != other.SelectEquipmentId)
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
		if (SelectEquipmentId != 0)
		{
			num ^= SelectEquipmentId.GetHashCode();
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
		if (SelectEquipmentId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(SelectEquipmentId);
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
		if (SelectEquipmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SelectEquipmentId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightRecommendEquipmentActionResult other)
	{
		if (other != null)
		{
			if (other.SelectEquipmentId != 0)
			{
				SelectEquipmentId = other.SelectEquipmentId;
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
			if (num != 56)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				SelectEquipmentId = input.ReadUInt32();
			}
		}
	}
}
