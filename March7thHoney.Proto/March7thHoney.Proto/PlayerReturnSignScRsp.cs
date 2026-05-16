using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnSignScRsp : IMessage<PlayerReturnSignScRsp>, IMessage, IEquatable<PlayerReturnSignScRsp>, IDeepCloneable<PlayerReturnSignScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnSignScRsp> _parser = new MessageParser<PlayerReturnSignScRsp>(() => new PlayerReturnSignScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int EBCAEFONDJCFieldNumber = 13;

	private static readonly FieldCodec<ItemList> _repeated_eBCAEFONDJC_codec = FieldCodec.ForMessage(106u, ItemList.Parser);

	private readonly RepeatedField<ItemList> eBCAEFONDJC_ = new RepeatedField<ItemList>();

	public const int DMHGDPBAALNFieldNumber = 15;

	private static readonly FieldCodec<KEOLEHHLHHM> _repeated_dMHGDPBAALN_codec = FieldCodec.ForMessage(122u, KEOLEHHLHHM.Parser);

	private readonly RepeatedField<KEOLEHHLHHM> dMHGDPBAALN_ = new RepeatedField<KEOLEHHLHHM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnSignScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnSignScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<ItemList> EBCAEFONDJC => eBCAEFONDJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KEOLEHHLHHM> DMHGDPBAALN => dMHGDPBAALN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnSignScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnSignScRsp(PlayerReturnSignScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		eBCAEFONDJC_ = other.eBCAEFONDJC_.Clone();
		dMHGDPBAALN_ = other.dMHGDPBAALN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnSignScRsp Clone()
	{
		return new PlayerReturnSignScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnSignScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnSignScRsp other)
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
		if (!eBCAEFONDJC_.Equals(other.eBCAEFONDJC_))
		{
			return false;
		}
		if (!dMHGDPBAALN_.Equals(other.dMHGDPBAALN_))
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
		num ^= eBCAEFONDJC_.GetHashCode();
		num ^= dMHGDPBAALN_.GetHashCode();
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
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		eBCAEFONDJC_.WriteTo(ref output, _repeated_eBCAEFONDJC_codec);
		dMHGDPBAALN_.WriteTo(ref output, _repeated_dMHGDPBAALN_codec);
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
		num += eBCAEFONDJC_.CalculateSize(_repeated_eBCAEFONDJC_codec);
		num += dMHGDPBAALN_.CalculateSize(_repeated_dMHGDPBAALN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerReturnSignScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			eBCAEFONDJC_.Add(other.eBCAEFONDJC_);
			dMHGDPBAALN_.Add(other.dMHGDPBAALN_);
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
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				eBCAEFONDJC_.AddEntriesFrom(ref input, _repeated_eBCAEFONDJC_codec);
				break;
			case 122u:
				dMHGDPBAALN_.AddEntriesFrom(ref input, _repeated_dMHGDPBAALN_codec);
				break;
			}
		}
	}
}
