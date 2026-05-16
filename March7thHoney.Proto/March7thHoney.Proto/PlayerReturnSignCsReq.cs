using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnSignCsReq : IMessage<PlayerReturnSignCsReq>, IMessage, IEquatable<PlayerReturnSignCsReq>, IDeepCloneable<PlayerReturnSignCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnSignCsReq> _parser = new MessageParser<PlayerReturnSignCsReq>(() => new PlayerReturnSignCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DMHGDPBAALNFieldNumber = 1;

	private static readonly FieldCodec<KEOLEHHLHHM> _repeated_dMHGDPBAALN_codec = FieldCodec.ForMessage(10u, KEOLEHHLHHM.Parser);

	private readonly RepeatedField<KEOLEHHLHHM> dMHGDPBAALN_ = new RepeatedField<KEOLEHHLHHM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnSignCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnSignCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KEOLEHHLHHM> DMHGDPBAALN => dMHGDPBAALN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnSignCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnSignCsReq(PlayerReturnSignCsReq other)
		: this()
	{
		dMHGDPBAALN_ = other.dMHGDPBAALN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnSignCsReq Clone()
	{
		return new PlayerReturnSignCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnSignCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnSignCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		num += dMHGDPBAALN_.CalculateSize(_repeated_dMHGDPBAALN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerReturnSignCsReq other)
	{
		if (other != null)
		{
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dMHGDPBAALN_.AddEntriesFrom(ref input, _repeated_dMHGDPBAALN_codec);
			}
		}
	}
}
