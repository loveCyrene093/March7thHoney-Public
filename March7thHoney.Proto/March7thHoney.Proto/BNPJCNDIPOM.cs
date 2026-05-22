using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BNPJCNDIPOM : IMessage<BNPJCNDIPOM>, IMessage, IEquatable<BNPJCNDIPOM>, IDeepCloneable<BNPJCNDIPOM>, IBufferMessage
{
	private static readonly MessageParser<BNPJCNDIPOM> _parser = new MessageParser<BNPJCNDIPOM>(() => new BNPJCNDIPOM());

	private UnknownFieldSet _unknownFields;

	public const int DBPNDCDECKDFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dBPNDCDECKD_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dBPNDCDECKD_ = new RepeatedField<uint>();

	public const int GDCGBIEFIGOFieldNumber = 5;

	private static readonly FieldCodec<FateBuffData> _repeated_gDCGBIEFIGO_codec = FieldCodec.ForMessage(42u, FateBuffData.Parser);

	private readonly RepeatedField<FateBuffData> gDCGBIEFIGO_ = new RepeatedField<FateBuffData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BNPJCNDIPOM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BNPJCNDIPOMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DBPNDCDECKD => dBPNDCDECKD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FateBuffData> GDCGBIEFIGO => gDCGBIEFIGO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNPJCNDIPOM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNPJCNDIPOM(BNPJCNDIPOM other)
		: this()
	{
		dBPNDCDECKD_ = other.dBPNDCDECKD_.Clone();
		gDCGBIEFIGO_ = other.gDCGBIEFIGO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNPJCNDIPOM Clone()
	{
		return new BNPJCNDIPOM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BNPJCNDIPOM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BNPJCNDIPOM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dBPNDCDECKD_.Equals(other.dBPNDCDECKD_))
		{
			return false;
		}
		if (!gDCGBIEFIGO_.Equals(other.gDCGBIEFIGO_))
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
		num ^= dBPNDCDECKD_.GetHashCode();
		num ^= gDCGBIEFIGO_.GetHashCode();
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
		dBPNDCDECKD_.WriteTo(ref output, _repeated_dBPNDCDECKD_codec);
		gDCGBIEFIGO_.WriteTo(ref output, _repeated_gDCGBIEFIGO_codec);
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
		num += dBPNDCDECKD_.CalculateSize(_repeated_dBPNDCDECKD_codec);
		num += gDCGBIEFIGO_.CalculateSize(_repeated_gDCGBIEFIGO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BNPJCNDIPOM other)
	{
		if (other != null)
		{
			dBPNDCDECKD_.Add(other.dBPNDCDECKD_);
			gDCGBIEFIGO_.Add(other.gDCGBIEFIGO_);
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
			case 24u:
			case 26u:
				dBPNDCDECKD_.AddEntriesFrom(ref input, _repeated_dBPNDCDECKD_codec);
				break;
			case 42u:
				gDCGBIEFIGO_.AddEntriesFrom(ref input, _repeated_gDCGBIEFIGO_codec);
				break;
			}
		}
	}
}
