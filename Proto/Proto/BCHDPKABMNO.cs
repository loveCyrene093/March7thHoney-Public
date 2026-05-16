using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BCHDPKABMNO : IMessage<BCHDPKABMNO>, IMessage, IEquatable<BCHDPKABMNO>, IDeepCloneable<BCHDPKABMNO>, IBufferMessage
{
	private static readonly MessageParser<BCHDPKABMNO> _parser = new MessageParser<BCHDPKABMNO>(() => new BCHDPKABMNO());

	private UnknownFieldSet _unknownFields;

	public const int NKJHKMBLIBLFieldNumber = 3;

	private static readonly FieldCodec<IPIMEGCPBGM> _repeated_nKJHKMBLIBL_codec = FieldCodec.ForMessage(26u, IPIMEGCPBGM.Parser);

	private readonly RepeatedField<IPIMEGCPBGM> nKJHKMBLIBL_ = new RepeatedField<IPIMEGCPBGM>();

	public const int FEAMOKBLIACFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_fEAMOKBLIAC_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> fEAMOKBLIAC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BCHDPKABMNO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BCHDPKABMNOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IPIMEGCPBGM> NKJHKMBLIBL => nKJHKMBLIBL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FEAMOKBLIAC => fEAMOKBLIAC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCHDPKABMNO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCHDPKABMNO(BCHDPKABMNO other)
		: this()
	{
		nKJHKMBLIBL_ = other.nKJHKMBLIBL_.Clone();
		fEAMOKBLIAC_ = other.fEAMOKBLIAC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCHDPKABMNO Clone()
	{
		return new BCHDPKABMNO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BCHDPKABMNO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BCHDPKABMNO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nKJHKMBLIBL_.Equals(other.nKJHKMBLIBL_))
		{
			return false;
		}
		if (!fEAMOKBLIAC_.Equals(other.fEAMOKBLIAC_))
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
		num ^= nKJHKMBLIBL_.GetHashCode();
		num ^= fEAMOKBLIAC_.GetHashCode();
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
		nKJHKMBLIBL_.WriteTo(ref output, _repeated_nKJHKMBLIBL_codec);
		fEAMOKBLIAC_.WriteTo(ref output, _repeated_fEAMOKBLIAC_codec);
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
		num += nKJHKMBLIBL_.CalculateSize(_repeated_nKJHKMBLIBL_codec);
		num += fEAMOKBLIAC_.CalculateSize(_repeated_fEAMOKBLIAC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BCHDPKABMNO other)
	{
		if (other != null)
		{
			nKJHKMBLIBL_.Add(other.nKJHKMBLIBL_);
			fEAMOKBLIAC_.Add(other.fEAMOKBLIAC_);
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
			case 26u:
				nKJHKMBLIBL_.AddEntriesFrom(ref input, _repeated_nKJHKMBLIBL_codec);
				break;
			case 56u:
			case 58u:
				fEAMOKBLIAC_.AddEntriesFrom(ref input, _repeated_fEAMOKBLIAC_codec);
				break;
			}
		}
	}
}
