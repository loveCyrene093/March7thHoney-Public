using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AJHELAAIMBG : IMessage<AJHELAAIMBG>, IMessage, IEquatable<AJHELAAIMBG>, IDeepCloneable<AJHELAAIMBG>, IBufferMessage
{
	private static readonly MessageParser<AJHELAAIMBG> _parser = new MessageParser<AJHELAAIMBG>(() => new AJHELAAIMBG());

	private UnknownFieldSet _unknownFields;

	public const int HINGMEBIBDLFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_hINGMEBIBDL_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> hINGMEBIBDL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AJHELAAIMBG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AJHELAAIMBGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HINGMEBIBDL => hINGMEBIBDL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJHELAAIMBG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJHELAAIMBG(AJHELAAIMBG other)
		: this()
	{
		hINGMEBIBDL_ = other.hINGMEBIBDL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJHELAAIMBG Clone()
	{
		return new AJHELAAIMBG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AJHELAAIMBG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AJHELAAIMBG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hINGMEBIBDL_.Equals(other.hINGMEBIBDL_))
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
		num ^= hINGMEBIBDL_.GetHashCode();
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
		hINGMEBIBDL_.WriteTo(ref output, _repeated_hINGMEBIBDL_codec);
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
		num += hINGMEBIBDL_.CalculateSize(_repeated_hINGMEBIBDL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AJHELAAIMBG other)
	{
		if (other != null)
		{
			hINGMEBIBDL_.Add(other.hINGMEBIBDL_);
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
			if (num != 80 && num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				hINGMEBIBDL_.AddEntriesFrom(ref input, _repeated_hINGMEBIBDL_codec);
			}
		}
	}
}
