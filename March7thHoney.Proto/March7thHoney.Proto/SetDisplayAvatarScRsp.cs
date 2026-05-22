using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetDisplayAvatarScRsp : IMessage<SetDisplayAvatarScRsp>, IMessage, IEquatable<SetDisplayAvatarScRsp>, IDeepCloneable<SetDisplayAvatarScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetDisplayAvatarScRsp> _parser = new MessageParser<SetDisplayAvatarScRsp>(() => new SetDisplayAvatarScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int DisplayAvatarListFieldNumber = 7;

	private static readonly FieldCodec<DisplayAvatarData> _repeated_displayAvatarList_codec = FieldCodec.ForMessage(58u, DisplayAvatarData.Parser);

	private readonly RepeatedField<DisplayAvatarData> displayAvatarList_ = new RepeatedField<DisplayAvatarData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetDisplayAvatarScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetDisplayAvatarScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<DisplayAvatarData> DisplayAvatarList => displayAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetDisplayAvatarScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetDisplayAvatarScRsp(SetDisplayAvatarScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		displayAvatarList_ = other.displayAvatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetDisplayAvatarScRsp Clone()
	{
		return new SetDisplayAvatarScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetDisplayAvatarScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetDisplayAvatarScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
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
	public void MergeFrom(SetDisplayAvatarScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
				Retcode = input.ReadUInt32();
				break;
			case 58u:
				displayAvatarList_.AddEntriesFrom(ref input, _repeated_displayAvatarList_codec);
				break;
			}
		}
	}
}
