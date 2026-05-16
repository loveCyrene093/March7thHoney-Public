using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DisplayAvatarVec : IMessage<DisplayAvatarVec>, IMessage, IEquatable<DisplayAvatarVec>, IDeepCloneable<DisplayAvatarVec>, IBufferMessage
{
	private static readonly MessageParser<DisplayAvatarVec> _parser = new MessageParser<DisplayAvatarVec>(() => new DisplayAvatarVec());

	private UnknownFieldSet _unknownFields;

	public const int IsDisplayFieldNumber = 1;

	private bool isDisplay_;

	public const int DisplayAvatarListFieldNumber = 7;

	private static readonly FieldCodec<DisplayAvatarData> _repeated_displayAvatarList_codec = FieldCodec.ForMessage(58u, DisplayAvatarData.Parser);

	private readonly RepeatedField<DisplayAvatarData> displayAvatarList_ = new RepeatedField<DisplayAvatarData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DisplayAvatarVec> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DisplayAvatarVecReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsDisplay
	{
		get
		{
			return isDisplay_;
		}
		set
		{
			isDisplay_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DisplayAvatarData> DisplayAvatarList => displayAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarVec()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarVec(DisplayAvatarVec other)
		: this()
	{
		isDisplay_ = other.isDisplay_;
		displayAvatarList_ = other.displayAvatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarVec Clone()
	{
		return new DisplayAvatarVec(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DisplayAvatarVec);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DisplayAvatarVec other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsDisplay != other.IsDisplay)
		{
			return false;
		}
		if (!displayAvatarList_.Equals(other.displayAvatarList_))
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
		if (IsDisplay)
		{
			num ^= IsDisplay.GetHashCode();
		}
		num ^= displayAvatarList_.GetHashCode();
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
		if (IsDisplay)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsDisplay);
		}
		displayAvatarList_.WriteTo(ref output, _repeated_displayAvatarList_codec);
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
		if (IsDisplay)
		{
			num += 2;
		}
		num += displayAvatarList_.CalculateSize(_repeated_displayAvatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DisplayAvatarVec other)
	{
		if (other != null)
		{
			if (other.IsDisplay)
			{
				IsDisplay = other.IsDisplay;
			}
			displayAvatarList_.Add(other.displayAvatarList_);
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
			case 8u:
				IsDisplay = input.ReadBool();
				break;
			case 58u:
				displayAvatarList_.AddEntriesFrom(ref input, _repeated_displayAvatarList_codec);
				break;
			}
		}
	}
}
