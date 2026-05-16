using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BIMPCMFDOME : IMessage<BIMPCMFDOME>, IMessage, IEquatable<BIMPCMFDOME>, IDeepCloneable<BIMPCMFDOME>, IBufferMessage
{
	private static readonly MessageParser<BIMPCMFDOME> _parser = new MessageParser<BIMPCMFDOME>(() => new BIMPCMFDOME());

	private UnknownFieldSet _unknownFields;

	public const int MPLHNFMFCPPFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_mPLHNFMFCPP_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> mPLHNFMFCPP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BIMPCMFDOME> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BIMPCMFDOMEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MPLHNFMFCPP => mPLHNFMFCPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIMPCMFDOME()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIMPCMFDOME(BIMPCMFDOME other)
		: this()
	{
		mPLHNFMFCPP_ = other.mPLHNFMFCPP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIMPCMFDOME Clone()
	{
		return new BIMPCMFDOME(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BIMPCMFDOME);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BIMPCMFDOME other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mPLHNFMFCPP_.Equals(other.mPLHNFMFCPP_))
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
		num ^= mPLHNFMFCPP_.GetHashCode();
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
		mPLHNFMFCPP_.WriteTo(ref output, _repeated_mPLHNFMFCPP_codec);
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
		num += mPLHNFMFCPP_.CalculateSize(_repeated_mPLHNFMFCPP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BIMPCMFDOME other)
	{
		if (other != null)
		{
			mPLHNFMFCPP_.Add(other.mPLHNFMFCPP_);
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
			if (num != 88 && num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mPLHNFMFCPP_.AddEntriesFrom(ref input, _repeated_mPLHNFMFCPP_codec);
			}
		}
	}
}
