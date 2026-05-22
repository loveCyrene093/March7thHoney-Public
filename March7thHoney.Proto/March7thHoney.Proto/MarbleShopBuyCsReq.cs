using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MarbleShopBuyCsReq : IMessage<MarbleShopBuyCsReq>, IMessage, IEquatable<MarbleShopBuyCsReq>, IDeepCloneable<MarbleShopBuyCsReq>, IBufferMessage
{
	private static readonly MessageParser<MarbleShopBuyCsReq> _parser = new MessageParser<MarbleShopBuyCsReq>(() => new MarbleShopBuyCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NLOINMODBLEFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_nLOINMODBLE_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> nLOINMODBLE_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MarbleShopBuyCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MarbleShopBuyCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NLOINMODBLE => nLOINMODBLE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarbleShopBuyCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarbleShopBuyCsReq(MarbleShopBuyCsReq other)
		: this()
	{
		nLOINMODBLE_ = other.nLOINMODBLE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarbleShopBuyCsReq Clone()
	{
		return new MarbleShopBuyCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MarbleShopBuyCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MarbleShopBuyCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nLOINMODBLE_.Equals(other.nLOINMODBLE_))
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
		num ^= nLOINMODBLE_.GetHashCode();
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
		nLOINMODBLE_.WriteTo(ref output, _repeated_nLOINMODBLE_codec);
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
		num += nLOINMODBLE_.CalculateSize(_repeated_nLOINMODBLE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MarbleShopBuyCsReq other)
	{
		if (other != null)
		{
			nLOINMODBLE_.Add(other.nLOINMODBLE_);
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
			if (num != 72 && num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				nLOINMODBLE_.AddEntriesFrom(ref input, _repeated_nLOINMODBLE_codec);
			}
		}
	}
}
