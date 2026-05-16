using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JJKNJOAJHBN : IMessage<JJKNJOAJHBN>, IMessage, IEquatable<JJKNJOAJHBN>, IDeepCloneable<JJKNJOAJHBN>, IBufferMessage
{
	private static readonly MessageParser<JJKNJOAJHBN> _parser = new MessageParser<JJKNJOAJHBN>(() => new JJKNJOAJHBN());

	private UnknownFieldSet _unknownFields;

	public const int LOIDOGEENOBFieldNumber = 6;

	private uint lOIDOGEENOB_;

	public const int RogueCurrentGameInfoFieldNumber = 9;

	private static readonly FieldCodec<EOOEGPCPHKP> _repeated_rogueCurrentGameInfo_codec = FieldCodec.ForMessage(74u, EOOEGPCPHKP.Parser);

	private readonly RepeatedField<EOOEGPCPHKP> rogueCurrentGameInfo_ = new RepeatedField<EOOEGPCPHKP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JJKNJOAJHBN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JJKNJOAJHBNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOIDOGEENOB
	{
		get
		{
			return lOIDOGEENOB_;
		}
		set
		{
			lOIDOGEENOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EOOEGPCPHKP> RogueCurrentGameInfo => rogueCurrentGameInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JJKNJOAJHBN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JJKNJOAJHBN(JJKNJOAJHBN other)
		: this()
	{
		lOIDOGEENOB_ = other.lOIDOGEENOB_;
		rogueCurrentGameInfo_ = other.rogueCurrentGameInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JJKNJOAJHBN Clone()
	{
		return new JJKNJOAJHBN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JJKNJOAJHBN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JJKNJOAJHBN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LOIDOGEENOB != other.LOIDOGEENOB)
		{
			return false;
		}
		if (!rogueCurrentGameInfo_.Equals(other.rogueCurrentGameInfo_))
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
		if (LOIDOGEENOB != 0)
		{
			num ^= LOIDOGEENOB.GetHashCode();
		}
		num ^= rogueCurrentGameInfo_.GetHashCode();
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
		if (LOIDOGEENOB != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LOIDOGEENOB);
		}
		rogueCurrentGameInfo_.WriteTo(ref output, _repeated_rogueCurrentGameInfo_codec);
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
		if (LOIDOGEENOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIDOGEENOB);
		}
		num += rogueCurrentGameInfo_.CalculateSize(_repeated_rogueCurrentGameInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JJKNJOAJHBN other)
	{
		if (other != null)
		{
			if (other.LOIDOGEENOB != 0)
			{
				LOIDOGEENOB = other.LOIDOGEENOB;
			}
			rogueCurrentGameInfo_.Add(other.rogueCurrentGameInfo_);
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
			case 48u:
				LOIDOGEENOB = input.ReadUInt32();
				break;
			case 74u:
				rogueCurrentGameInfo_.AddEntriesFrom(ref input, _repeated_rogueCurrentGameInfo_codec);
				break;
			}
		}
	}
}
