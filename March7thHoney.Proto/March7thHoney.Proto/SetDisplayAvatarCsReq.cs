using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetDisplayAvatarCsReq : IMessage<SetDisplayAvatarCsReq>, IMessage, IEquatable<SetDisplayAvatarCsReq>, IDeepCloneable<SetDisplayAvatarCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetDisplayAvatarCsReq> _parser = new MessageParser<SetDisplayAvatarCsReq>(() => new SetDisplayAvatarCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DisplayAvatarListFieldNumber = 14;

	private static readonly FieldCodec<DisplayAvatarData> _repeated_displayAvatarList_codec = FieldCodec.ForMessage(114u, DisplayAvatarData.Parser);

	private readonly RepeatedField<DisplayAvatarData> displayAvatarList_ = new RepeatedField<DisplayAvatarData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetDisplayAvatarCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetDisplayAvatarCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DisplayAvatarData> DisplayAvatarList => displayAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetDisplayAvatarCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetDisplayAvatarCsReq(SetDisplayAvatarCsReq other)
		: this()
	{
		displayAvatarList_ = other.displayAvatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetDisplayAvatarCsReq Clone()
	{
		return new SetDisplayAvatarCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetDisplayAvatarCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetDisplayAvatarCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		num += displayAvatarList_.CalculateSize(_repeated_displayAvatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetDisplayAvatarCsReq other)
	{
		if (other != null)
		{
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				displayAvatarList_.AddEntriesFrom(ref input, _repeated_displayAvatarList_codec);
			}
		}
	}
}
