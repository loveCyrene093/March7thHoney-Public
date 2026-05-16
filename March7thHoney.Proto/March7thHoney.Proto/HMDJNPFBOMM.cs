using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HMDJNPFBOMM : IMessage<HMDJNPFBOMM>, IMessage, IEquatable<HMDJNPFBOMM>, IDeepCloneable<HMDJNPFBOMM>, IBufferMessage
{
	private static readonly MessageParser<HMDJNPFBOMM> _parser = new MessageParser<HMDJNPFBOMM>(() => new HMDJNPFBOMM());

	private UnknownFieldSet _unknownFields;

	public const int IMBCJKHMOABFieldNumber = 1;

	private static readonly FieldCodec<EHKEJEPNGMB> _repeated_iMBCJKHMOAB_codec = FieldCodec.ForMessage(10u, EHKEJEPNGMB.Parser);

	private readonly RepeatedField<EHKEJEPNGMB> iMBCJKHMOAB_ = new RepeatedField<EHKEJEPNGMB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HMDJNPFBOMM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HMDJNPFBOMMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EHKEJEPNGMB> IMBCJKHMOAB => iMBCJKHMOAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMDJNPFBOMM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMDJNPFBOMM(HMDJNPFBOMM other)
		: this()
	{
		iMBCJKHMOAB_ = other.iMBCJKHMOAB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMDJNPFBOMM Clone()
	{
		return new HMDJNPFBOMM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HMDJNPFBOMM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HMDJNPFBOMM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iMBCJKHMOAB_.Equals(other.iMBCJKHMOAB_))
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
		num ^= iMBCJKHMOAB_.GetHashCode();
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
		iMBCJKHMOAB_.WriteTo(ref output, _repeated_iMBCJKHMOAB_codec);
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
		num += iMBCJKHMOAB_.CalculateSize(_repeated_iMBCJKHMOAB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HMDJNPFBOMM other)
	{
		if (other != null)
		{
			iMBCJKHMOAB_.Add(other.iMBCJKHMOAB_);
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
				iMBCJKHMOAB_.AddEntriesFrom(ref input, _repeated_iMBCJKHMOAB_codec);
			}
		}
	}
}
