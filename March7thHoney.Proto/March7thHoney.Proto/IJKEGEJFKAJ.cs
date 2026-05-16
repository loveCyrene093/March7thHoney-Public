using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IJKEGEJFKAJ : IMessage<IJKEGEJFKAJ>, IMessage, IEquatable<IJKEGEJFKAJ>, IDeepCloneable<IJKEGEJFKAJ>, IBufferMessage
{
	private static readonly MessageParser<IJKEGEJFKAJ> _parser = new MessageParser<IJKEGEJFKAJ>(() => new IJKEGEJFKAJ());

	private UnknownFieldSet _unknownFields;

	public const int GGALMCJNCNMFieldNumber = 4;

	private uint gGALMCJNCNM_;

	public const int AvatarListFieldNumber = 7;

	private static readonly FieldCodec<EEBPHJCNBFO> _repeated_avatarList_codec = FieldCodec.ForMessage(58u, EEBPHJCNBFO.Parser);

	private readonly RepeatedField<EEBPHJCNBFO> avatarList_ = new RepeatedField<EEBPHJCNBFO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IJKEGEJFKAJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IJKEGEJFKAJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GGALMCJNCNM
	{
		get
		{
			return gGALMCJNCNM_;
		}
		set
		{
			gGALMCJNCNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBPHJCNBFO> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJKEGEJFKAJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJKEGEJFKAJ(IJKEGEJFKAJ other)
		: this()
	{
		gGALMCJNCNM_ = other.gGALMCJNCNM_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJKEGEJFKAJ Clone()
	{
		return new IJKEGEJFKAJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IJKEGEJFKAJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IJKEGEJFKAJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GGALMCJNCNM != other.GGALMCJNCNM)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		if (GGALMCJNCNM != 0)
		{
			num ^= GGALMCJNCNM.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
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
		if (GGALMCJNCNM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GGALMCJNCNM);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		if (GGALMCJNCNM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GGALMCJNCNM);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IJKEGEJFKAJ other)
	{
		if (other != null)
		{
			if (other.GGALMCJNCNM != 0)
			{
				GGALMCJNCNM = other.GGALMCJNCNM;
			}
			avatarList_.Add(other.avatarList_);
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
				GGALMCJNCNM = input.ReadUInt32();
				break;
			case 58u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
