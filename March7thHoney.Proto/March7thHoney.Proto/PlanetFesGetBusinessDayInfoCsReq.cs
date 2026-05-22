using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesGetBusinessDayInfoCsReq : IMessage<PlanetFesGetBusinessDayInfoCsReq>, IMessage, IEquatable<PlanetFesGetBusinessDayInfoCsReq>, IDeepCloneable<PlanetFesGetBusinessDayInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesGetBusinessDayInfoCsReq> _parser = new MessageParser<PlanetFesGetBusinessDayInfoCsReq>(() => new PlanetFesGetBusinessDayInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BOACDLKCJJIFieldNumber = 2;

	private bool bOACDLKCJJI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesGetBusinessDayInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesGetBusinessDayInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BOACDLKCJJI
	{
		get
		{
			return bOACDLKCJJI_;
		}
		set
		{
			bOACDLKCJJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetBusinessDayInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetBusinessDayInfoCsReq(PlanetFesGetBusinessDayInfoCsReq other)
		: this()
	{
		bOACDLKCJJI_ = other.bOACDLKCJJI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesGetBusinessDayInfoCsReq Clone()
	{
		return new PlanetFesGetBusinessDayInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesGetBusinessDayInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesGetBusinessDayInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BOACDLKCJJI != other.BOACDLKCJJI)
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
		if (BOACDLKCJJI)
		{
			num ^= BOACDLKCJJI.GetHashCode();
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
		if (BOACDLKCJJI)
		{
			output.WriteRawTag(16);
			output.WriteBool(BOACDLKCJJI);
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
		if (BOACDLKCJJI)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesGetBusinessDayInfoCsReq other)
	{
		if (other != null)
		{
			if (other.BOACDLKCJJI)
			{
				BOACDLKCJJI = other.BOACDLKCJJI;
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
			if (num != 16)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				BOACDLKCJJI = input.ReadBool();
			}
		}
	}
}
