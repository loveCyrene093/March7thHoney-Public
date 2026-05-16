using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGameAugmentUpdate : IMessage<GridFightGameAugmentUpdate>, IMessage, IEquatable<GridFightGameAugmentUpdate>, IDeepCloneable<GridFightGameAugmentUpdate>, IBufferMessage
{
	private static readonly MessageParser<GridFightGameAugmentUpdate> _parser = new MessageParser<GridFightGameAugmentUpdate>(() => new GridFightGameAugmentUpdate());

	private UnknownFieldSet _unknownFields;

	public const int UpdateAugmentInfoFieldNumber = 3;

	private GridGameAugmentInfo updateAugmentInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGameAugmentUpdate> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGameAugmentUpdateReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameAugmentInfo UpdateAugmentInfo
	{
		get
		{
			return updateAugmentInfo_;
		}
		set
		{
			updateAugmentInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentUpdate()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentUpdate(GridFightGameAugmentUpdate other)
		: this()
	{
		updateAugmentInfo_ = ((other.updateAugmentInfo_ != null) ? other.updateAugmentInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGameAugmentUpdate Clone()
	{
		return new GridFightGameAugmentUpdate(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGameAugmentUpdate);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGameAugmentUpdate other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(UpdateAugmentInfo, other.UpdateAugmentInfo))
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
		if (updateAugmentInfo_ != null)
		{
			num ^= UpdateAugmentInfo.GetHashCode();
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
		if (updateAugmentInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(UpdateAugmentInfo);
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
		if (updateAugmentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UpdateAugmentInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGameAugmentUpdate other)
	{
		if (other == null)
		{
			return;
		}
		if (other.updateAugmentInfo_ != null)
		{
			if (updateAugmentInfo_ == null)
			{
				UpdateAugmentInfo = new GridGameAugmentInfo();
			}
			UpdateAugmentInfo.MergeFrom(other.UpdateAugmentInfo);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (updateAugmentInfo_ == null)
			{
				UpdateAugmentInfo = new GridGameAugmentInfo();
			}
			input.ReadMessage(UpdateAugmentInfo);
		}
	}
}
