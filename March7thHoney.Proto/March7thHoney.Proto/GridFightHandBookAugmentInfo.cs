using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightHandBookAugmentInfo : IMessage<GridFightHandBookAugmentInfo>, IMessage, IEquatable<GridFightHandBookAugmentInfo>, IDeepCloneable<GridFightHandBookAugmentInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightHandBookAugmentInfo> _parser = new MessageParser<GridFightHandBookAugmentInfo>(() => new GridFightHandBookAugmentInfo());

	private UnknownFieldSet _unknownFields;

	public const int KDFBCMANFMBFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_kDFBCMANFMB_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> kDFBCMANFMB_ = new RepeatedField<uint>();

	public const int JLCDEDKPEABFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_jLCDEDKPEAB_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> jLCDEDKPEAB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightHandBookAugmentInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightHandBookAugmentInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KDFBCMANFMB => kDFBCMANFMB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JLCDEDKPEAB => jLCDEDKPEAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookAugmentInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookAugmentInfo(GridFightHandBookAugmentInfo other)
		: this()
	{
		kDFBCMANFMB_ = other.kDFBCMANFMB_.Clone();
		jLCDEDKPEAB_ = other.jLCDEDKPEAB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookAugmentInfo Clone()
	{
		return new GridFightHandBookAugmentInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightHandBookAugmentInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightHandBookAugmentInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kDFBCMANFMB_.Equals(other.kDFBCMANFMB_))
		{
			return false;
		}
		if (!jLCDEDKPEAB_.Equals(other.jLCDEDKPEAB_))
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
		num ^= kDFBCMANFMB_.GetHashCode();
		num ^= jLCDEDKPEAB_.GetHashCode();
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
		kDFBCMANFMB_.WriteTo(ref output, _repeated_kDFBCMANFMB_codec);
		jLCDEDKPEAB_.WriteTo(ref output, _repeated_jLCDEDKPEAB_codec);
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
		num += kDFBCMANFMB_.CalculateSize(_repeated_kDFBCMANFMB_codec);
		num += jLCDEDKPEAB_.CalculateSize(_repeated_jLCDEDKPEAB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightHandBookAugmentInfo other)
	{
		if (other != null)
		{
			kDFBCMANFMB_.Add(other.kDFBCMANFMB_);
			jLCDEDKPEAB_.Add(other.jLCDEDKPEAB_);
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
			case 88u:
			case 90u:
				kDFBCMANFMB_.AddEntriesFrom(ref input, _repeated_kDFBCMANFMB_codec);
				break;
			case 104u:
			case 106u:
				jLCDEDKPEAB_.AddEntriesFrom(ref input, _repeated_jLCDEDKPEAB_codec);
				break;
			}
		}
	}
}
