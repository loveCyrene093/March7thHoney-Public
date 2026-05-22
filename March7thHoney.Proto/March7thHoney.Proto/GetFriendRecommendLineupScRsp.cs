using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFriendRecommendLineupScRsp : IMessage<GetFriendRecommendLineupScRsp>, IMessage, IEquatable<GetFriendRecommendLineupScRsp>, IDeepCloneable<GetFriendRecommendLineupScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFriendRecommendLineupScRsp> _parser = new MessageParser<GetFriendRecommendLineupScRsp>(() => new GetFriendRecommendLineupScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int KeyFieldNumber = 3;

	private uint key_;

	public const int TypeFieldNumber = 4;

	private NFKEJJIHOCJ type_;

	public const int DAOKDPJACJFFieldNumber = 5;

	private static readonly FieldCodec<HBJCPIOLEIC> _repeated_dAOKDPJACJF_codec = FieldCodec.ForMessage(42u, HBJCPIOLEIC.Parser);

	private readonly RepeatedField<HBJCPIOLEIC> dAOKDPJACJF_ = new RepeatedField<HBJCPIOLEIC>();

	public const int OEDONMBJFCGFieldNumber = 15;

	private bool oEDONMBJFCG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFriendRecommendLineupScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFriendRecommendLineupScRspReflection.Descriptor.MessageTypes[0];

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
	public uint Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFKEJJIHOCJ Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HBJCPIOLEIC> DAOKDPJACJF => dAOKDPJACJF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OEDONMBJFCG
	{
		get
		{
			return oEDONMBJFCG_;
		}
		set
		{
			oEDONMBJFCG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendRecommendLineupScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendRecommendLineupScRsp(GetFriendRecommendLineupScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		key_ = other.key_;
		type_ = other.type_;
		dAOKDPJACJF_ = other.dAOKDPJACJF_.Clone();
		oEDONMBJFCG_ = other.oEDONMBJFCG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendRecommendLineupScRsp Clone()
	{
		return new GetFriendRecommendLineupScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFriendRecommendLineupScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFriendRecommendLineupScRsp other)
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
		if (Key != other.Key)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (!dAOKDPJACJF_.Equals(other.dAOKDPJACJF_))
		{
			return false;
		}
		if (OEDONMBJFCG != other.OEDONMBJFCG)
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
		if (Key != 0)
		{
			num ^= Key.GetHashCode();
		}
		if (Type != NFKEJJIHOCJ.Pcpdhelpkem)
		{
			num ^= Type.GetHashCode();
		}
		num ^= dAOKDPJACJF_.GetHashCode();
		if (OEDONMBJFCG)
		{
			num ^= OEDONMBJFCG.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (Key != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Key);
		}
		if (Type != NFKEJJIHOCJ.Pcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Type);
		}
		dAOKDPJACJF_.WriteTo(ref output, _repeated_dAOKDPJACJF_codec);
		if (OEDONMBJFCG)
		{
			output.WriteRawTag(120);
			output.WriteBool(OEDONMBJFCG);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Key != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Key);
		}
		if (Type != NFKEJJIHOCJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		num += dAOKDPJACJF_.CalculateSize(_repeated_dAOKDPJACJF_codec);
		if (OEDONMBJFCG)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFriendRecommendLineupScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.Key != 0)
			{
				Key = other.Key;
			}
			if (other.Type != NFKEJJIHOCJ.Pcpdhelpkem)
			{
				Type = other.Type;
			}
			dAOKDPJACJF_.Add(other.dAOKDPJACJF_);
			if (other.OEDONMBJFCG)
			{
				OEDONMBJFCG = other.OEDONMBJFCG;
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 24u:
				Key = input.ReadUInt32();
				break;
			case 32u:
				Type = (NFKEJJIHOCJ)input.ReadEnum();
				break;
			case 42u:
				dAOKDPJACJF_.AddEntriesFrom(ref input, _repeated_dAOKDPJACJF_codec);
				break;
			case 120u:
				OEDONMBJFCG = input.ReadBool();
				break;
			}
		}
	}
}
