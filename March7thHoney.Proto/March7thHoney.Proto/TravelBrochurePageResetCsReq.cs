using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TravelBrochurePageResetCsReq : IMessage<TravelBrochurePageResetCsReq>, IMessage, IEquatable<TravelBrochurePageResetCsReq>, IDeepCloneable<TravelBrochurePageResetCsReq>, IBufferMessage
{
	private static readonly MessageParser<TravelBrochurePageResetCsReq> _parser = new MessageParser<TravelBrochurePageResetCsReq>(() => new TravelBrochurePageResetCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HBCJPCMJPHEFieldNumber = 3;

	private uint hBCJPCMJPHE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TravelBrochurePageResetCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TravelBrochurePageResetCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBCJPCMJPHE
	{
		get
		{
			return hBCJPCMJPHE_;
		}
		set
		{
			hBCJPCMJPHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochurePageResetCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochurePageResetCsReq(TravelBrochurePageResetCsReq other)
		: this()
	{
		hBCJPCMJPHE_ = other.hBCJPCMJPHE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochurePageResetCsReq Clone()
	{
		return new TravelBrochurePageResetCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TravelBrochurePageResetCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TravelBrochurePageResetCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HBCJPCMJPHE != other.HBCJPCMJPHE)
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
		if (HBCJPCMJPHE != 0)
		{
			num ^= HBCJPCMJPHE.GetHashCode();
		}
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
		if (HBCJPCMJPHE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HBCJPCMJPHE);
		}
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
		if (HBCJPCMJPHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBCJPCMJPHE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TravelBrochurePageResetCsReq other)
	{
		if (other != null)
		{
			if (other.HBCJPCMJPHE != 0)
			{
				HBCJPCMJPHE = other.HBCJPCMJPHE;
			}
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
			if (num != 24)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HBCJPCMJPHE = input.ReadUInt32();
			}
		}
	}
}
