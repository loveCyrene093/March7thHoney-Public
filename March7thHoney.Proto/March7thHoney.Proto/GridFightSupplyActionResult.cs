using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSupplyActionResult : IMessage<GridFightSupplyActionResult>, IMessage, IEquatable<GridFightSupplyActionResult>, IDeepCloneable<GridFightSupplyActionResult>, IBufferMessage
{
	private static readonly MessageParser<GridFightSupplyActionResult> _parser = new MessageParser<GridFightSupplyActionResult>(() => new GridFightSupplyActionResult());

	private UnknownFieldSet _unknownFields;

	public const int SelectSupplyIndexesFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_selectSupplyIndexes_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> selectSupplyIndexes_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSupplyActionResult> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSupplyActionResultReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SelectSupplyIndexes => selectSupplyIndexes_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSupplyActionResult()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSupplyActionResult(GridFightSupplyActionResult other)
		: this()
	{
		selectSupplyIndexes_ = other.selectSupplyIndexes_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSupplyActionResult Clone()
	{
		return new GridFightSupplyActionResult(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSupplyActionResult);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSupplyActionResult other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!selectSupplyIndexes_.Equals(other.selectSupplyIndexes_))
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
		num ^= selectSupplyIndexes_.GetHashCode();
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
		selectSupplyIndexes_.WriteTo(ref output, _repeated_selectSupplyIndexes_codec);
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
		num += selectSupplyIndexes_.CalculateSize(_repeated_selectSupplyIndexes_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSupplyActionResult other)
	{
		if (other != null)
		{
			selectSupplyIndexes_.Add(other.selectSupplyIndexes_);
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
			if (num != 48 && num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				selectSupplyIndexes_.AddEntriesFrom(ref input, _repeated_selectSupplyIndexes_codec);
			}
		}
	}
}
