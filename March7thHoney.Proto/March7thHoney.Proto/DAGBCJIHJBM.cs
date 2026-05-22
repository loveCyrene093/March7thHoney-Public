using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DAGBCJIHJBM : IMessage<DAGBCJIHJBM>, IMessage, IEquatable<DAGBCJIHJBM>, IDeepCloneable<DAGBCJIHJBM>, IBufferMessage
{
	private static readonly MessageParser<DAGBCJIHJBM> _parser = new MessageParser<DAGBCJIHJBM>(() => new DAGBCJIHJBM());

	private UnknownFieldSet _unknownFields;

	public const int ELCPONIPEIHFieldNumber = 7;

	private static readonly FieldCodec<DKMEKAPJNLH> _repeated_eLCPONIPEIH_codec = FieldCodec.ForMessage(58u, DKMEKAPJNLH.Parser);

	private readonly RepeatedField<DKMEKAPJNLH> eLCPONIPEIH_ = new RepeatedField<DKMEKAPJNLH>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DAGBCJIHJBM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DAGBCJIHJBMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DKMEKAPJNLH> ELCPONIPEIH => eLCPONIPEIH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAGBCJIHJBM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAGBCJIHJBM(DAGBCJIHJBM other)
		: this()
	{
		eLCPONIPEIH_ = other.eLCPONIPEIH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAGBCJIHJBM Clone()
	{
		return new DAGBCJIHJBM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DAGBCJIHJBM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DAGBCJIHJBM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eLCPONIPEIH_.Equals(other.eLCPONIPEIH_))
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
		num ^= eLCPONIPEIH_.GetHashCode();
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
		eLCPONIPEIH_.WriteTo(ref output, _repeated_eLCPONIPEIH_codec);
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
		num += eLCPONIPEIH_.CalculateSize(_repeated_eLCPONIPEIH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DAGBCJIHJBM other)
	{
		if (other != null)
		{
			eLCPONIPEIH_.Add(other.eLCPONIPEIH_);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				eLCPONIPEIH_.AddEntriesFrom(ref input, _repeated_eLCPONIPEIH_codec);
			}
		}
	}
}
