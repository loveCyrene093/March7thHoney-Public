using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CDHOKMAAMFD : IMessage<CDHOKMAAMFD>, IMessage, IEquatable<CDHOKMAAMFD>, IDeepCloneable<CDHOKMAAMFD>, IBufferMessage
{
	private static readonly MessageParser<CDHOKMAAMFD> _parser = new MessageParser<CDHOKMAAMFD>(() => new CDHOKMAAMFD());

	private UnknownFieldSet _unknownFields;

	public const int DNCNPNBLENFFieldNumber = 2;

	private static readonly FieldCodec<IPJOJKPBFGK> _repeated_dNCNPNBLENF_codec = FieldCodec.ForMessage(18u, IPJOJKPBFGK.Parser);

	private readonly RepeatedField<IPJOJKPBFGK> dNCNPNBLENF_ = new RepeatedField<IPJOJKPBFGK>();

	public const int FEDJJBBHCCGFieldNumber = 12;

	private static readonly FieldCodec<JCJACKICPHN> _repeated_fEDJJBBHCCG_codec = FieldCodec.ForMessage(98u, JCJACKICPHN.Parser);

	private readonly RepeatedField<JCJACKICPHN> fEDJJBBHCCG_ = new RepeatedField<JCJACKICPHN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CDHOKMAAMFD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CDHOKMAAMFDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IPJOJKPBFGK> DNCNPNBLENF => dNCNPNBLENF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JCJACKICPHN> FEDJJBBHCCG => fEDJJBBHCCG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDHOKMAAMFD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDHOKMAAMFD(CDHOKMAAMFD other)
		: this()
	{
		dNCNPNBLENF_ = other.dNCNPNBLENF_.Clone();
		fEDJJBBHCCG_ = other.fEDJJBBHCCG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDHOKMAAMFD Clone()
	{
		return new CDHOKMAAMFD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CDHOKMAAMFD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CDHOKMAAMFD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dNCNPNBLENF_.Equals(other.dNCNPNBLENF_))
		{
			return false;
		}
		if (!fEDJJBBHCCG_.Equals(other.fEDJJBBHCCG_))
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
		num ^= dNCNPNBLENF_.GetHashCode();
		num ^= fEDJJBBHCCG_.GetHashCode();
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
		dNCNPNBLENF_.WriteTo(ref output, _repeated_dNCNPNBLENF_codec);
		fEDJJBBHCCG_.WriteTo(ref output, _repeated_fEDJJBBHCCG_codec);
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
		num += dNCNPNBLENF_.CalculateSize(_repeated_dNCNPNBLENF_codec);
		num += fEDJJBBHCCG_.CalculateSize(_repeated_fEDJJBBHCCG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CDHOKMAAMFD other)
	{
		if (other != null)
		{
			dNCNPNBLENF_.Add(other.dNCNPNBLENF_);
			fEDJJBBHCCG_.Add(other.fEDJJBBHCCG_);
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
			case 18u:
				dNCNPNBLENF_.AddEntriesFrom(ref input, _repeated_dNCNPNBLENF_codec);
				break;
			case 98u:
				fEDJJBBHCCG_.AddEntriesFrom(ref input, _repeated_fEDJJBBHCCG_codec);
				break;
			}
		}
	}
}
