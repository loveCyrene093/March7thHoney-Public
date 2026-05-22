using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightPortalBuffActionResult : IMessage<GridFightPortalBuffActionResult>, IMessage, IEquatable<GridFightPortalBuffActionResult>, IDeepCloneable<GridFightPortalBuffActionResult>, IBufferMessage
{
	private static readonly MessageParser<GridFightPortalBuffActionResult> _parser = new MessageParser<GridFightPortalBuffActionResult>(() => new GridFightPortalBuffActionResult());

	private UnknownFieldSet _unknownFields;

	public const int SelectPortalBuffIdFieldNumber = 9;

	private uint selectPortalBuffId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightPortalBuffActionResult> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightPortalBuffActionResultReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SelectPortalBuffId
	{
		get
		{
			return selectPortalBuffId_;
		}
		set
		{
			selectPortalBuffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalBuffActionResult()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalBuffActionResult(GridFightPortalBuffActionResult other)
		: this()
	{
		selectPortalBuffId_ = other.selectPortalBuffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalBuffActionResult Clone()
	{
		return new GridFightPortalBuffActionResult(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightPortalBuffActionResult);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightPortalBuffActionResult other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SelectPortalBuffId != other.SelectPortalBuffId)
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
		if (SelectPortalBuffId != 0)
		{
			num ^= SelectPortalBuffId.GetHashCode();
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
		if (SelectPortalBuffId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(SelectPortalBuffId);
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
		if (SelectPortalBuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SelectPortalBuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightPortalBuffActionResult other)
	{
		if (other != null)
		{
			if (other.SelectPortalBuffId != 0)
			{
				SelectPortalBuffId = other.SelectPortalBuffId;
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
			if (num != 72)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				SelectPortalBuffId = input.ReadUInt32();
			}
		}
	}
}
