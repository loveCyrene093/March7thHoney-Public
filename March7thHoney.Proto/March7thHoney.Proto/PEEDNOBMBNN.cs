using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PEEDNOBMBNN : IMessage<PEEDNOBMBNN>, IMessage, IEquatable<PEEDNOBMBNN>, IDeepCloneable<PEEDNOBMBNN>, IBufferMessage
{
	private static readonly MessageParser<PEEDNOBMBNN> _parser = new MessageParser<PEEDNOBMBNN>(() => new PEEDNOBMBNN());

	private UnknownFieldSet _unknownFields;

	public const int GHEKIEAOMLJFieldNumber = 3;

	private ADMCMFIINIH gHEKIEAOMLJ_;

	public const int MHCABCEDNGBFieldNumber = 10;

	private static readonly FieldCodec<HACNBJJOLHP> _repeated_mHCABCEDNGB_codec = FieldCodec.ForMessage(82u, HACNBJJOLHP.Parser);

	private readonly RepeatedField<HACNBJJOLHP> mHCABCEDNGB_ = new RepeatedField<HACNBJJOLHP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PEEDNOBMBNN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PEEDNOBMBNNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADMCMFIINIH GHEKIEAOMLJ
	{
		get
		{
			return gHEKIEAOMLJ_;
		}
		set
		{
			gHEKIEAOMLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HACNBJJOLHP> MHCABCEDNGB => mHCABCEDNGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEEDNOBMBNN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEEDNOBMBNN(PEEDNOBMBNN other)
		: this()
	{
		gHEKIEAOMLJ_ = ((other.gHEKIEAOMLJ_ != null) ? other.gHEKIEAOMLJ_.Clone() : null);
		mHCABCEDNGB_ = other.mHCABCEDNGB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEEDNOBMBNN Clone()
	{
		return new PEEDNOBMBNN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PEEDNOBMBNN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PEEDNOBMBNN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GHEKIEAOMLJ, other.GHEKIEAOMLJ))
		{
			return false;
		}
		if (!mHCABCEDNGB_.Equals(other.mHCABCEDNGB_))
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
		if (gHEKIEAOMLJ_ != null)
		{
			num ^= GHEKIEAOMLJ.GetHashCode();
		}
		num ^= mHCABCEDNGB_.GetHashCode();
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
		if (gHEKIEAOMLJ_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(GHEKIEAOMLJ);
		}
		mHCABCEDNGB_.WriteTo(ref output, _repeated_mHCABCEDNGB_codec);
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
		if (gHEKIEAOMLJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GHEKIEAOMLJ);
		}
		num += mHCABCEDNGB_.CalculateSize(_repeated_mHCABCEDNGB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PEEDNOBMBNN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gHEKIEAOMLJ_ != null)
		{
			if (gHEKIEAOMLJ_ == null)
			{
				GHEKIEAOMLJ = new ADMCMFIINIH();
			}
			GHEKIEAOMLJ.MergeFrom(other.GHEKIEAOMLJ);
		}
		mHCABCEDNGB_.Add(other.mHCABCEDNGB_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (gHEKIEAOMLJ_ == null)
				{
					GHEKIEAOMLJ = new ADMCMFIINIH();
				}
				input.ReadMessage(GHEKIEAOMLJ);
				break;
			case 82u:
				mHCABCEDNGB_.AddEntriesFrom(ref input, _repeated_mHCABCEDNGB_codec);
				break;
			}
		}
	}
}
