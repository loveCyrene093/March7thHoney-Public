using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EHNENCJAJPC : IMessage<EHNENCJAJPC>, IMessage, IEquatable<EHNENCJAJPC>, IDeepCloneable<EHNENCJAJPC>, IBufferMessage
{
	public enum FFGIEFNOLHNOneofCase
	{
		None = 0,
		FHDJFAMMNOF = 11,
		CGOABGKCBEF = 14
	}

	private static readonly MessageParser<EHNENCJAJPC> _parser = new MessageParser<EHNENCJAJPC>(() => new EHNENCJAJPC());

	private UnknownFieldSet _unknownFields;

	public const int FHDJFAMMNOFFieldNumber = 11;

	public const int CGOABGKCBEFFieldNumber = 14;

	private object fFGIEFNOLHN_;

	private FFGIEFNOLHNOneofCase fFGIEFNOLHNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EHNENCJAJPC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EHNENCJAJPCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHDJFAMMNOF
	{
		get
		{
			if (!HasFHDJFAMMNOF)
			{
				return 0u;
			}
			return (uint)fFGIEFNOLHN_;
		}
		set
		{
			fFGIEFNOLHN_ = value;
			fFGIEFNOLHNCase_ = FFGIEFNOLHNOneofCase.FHDJFAMMNOF;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFHDJFAMMNOF => fFGIEFNOLHNCase_ == FFGIEFNOLHNOneofCase.FHDJFAMMNOF;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CGOABGKCBEF
	{
		get
		{
			if (!HasCGOABGKCBEF)
			{
				return 0u;
			}
			return (uint)fFGIEFNOLHN_;
		}
		set
		{
			fFGIEFNOLHN_ = value;
			fFGIEFNOLHNCase_ = FFGIEFNOLHNOneofCase.CGOABGKCBEF;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCGOABGKCBEF => fFGIEFNOLHNCase_ == FFGIEFNOLHNOneofCase.CGOABGKCBEF;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFGIEFNOLHNOneofCase FFGIEFNOLHNCase => fFGIEFNOLHNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EHNENCJAJPC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EHNENCJAJPC(EHNENCJAJPC other)
		: this()
	{
		switch (other.FFGIEFNOLHNCase)
		{
		case FFGIEFNOLHNOneofCase.FHDJFAMMNOF:
			FHDJFAMMNOF = other.FHDJFAMMNOF;
			break;
		case FFGIEFNOLHNOneofCase.CGOABGKCBEF:
			CGOABGKCBEF = other.CGOABGKCBEF;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EHNENCJAJPC Clone()
	{
		return new EHNENCJAJPC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFHDJFAMMNOF()
	{
		if (HasFHDJFAMMNOF)
		{
			ClearFFGIEFNOLHN();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCGOABGKCBEF()
	{
		if (HasCGOABGKCBEF)
		{
			ClearFFGIEFNOLHN();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFFGIEFNOLHN()
	{
		fFGIEFNOLHNCase_ = FFGIEFNOLHNOneofCase.None;
		fFGIEFNOLHN_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EHNENCJAJPC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EHNENCJAJPC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FHDJFAMMNOF != other.FHDJFAMMNOF)
		{
			return false;
		}
		if (CGOABGKCBEF != other.CGOABGKCBEF)
		{
			return false;
		}
		if (FFGIEFNOLHNCase != other.FFGIEFNOLHNCase)
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
		if (HasFHDJFAMMNOF)
		{
			num ^= FHDJFAMMNOF.GetHashCode();
		}
		if (HasCGOABGKCBEF)
		{
			num ^= CGOABGKCBEF.GetHashCode();
		}
		num ^= (int)fFGIEFNOLHNCase_;
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
		if (HasFHDJFAMMNOF)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FHDJFAMMNOF);
		}
		if (HasCGOABGKCBEF)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CGOABGKCBEF);
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
		if (HasFHDJFAMMNOF)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHDJFAMMNOF);
		}
		if (HasCGOABGKCBEF)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CGOABGKCBEF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EHNENCJAJPC other)
	{
		if (other != null)
		{
			switch (other.FFGIEFNOLHNCase)
			{
			case FFGIEFNOLHNOneofCase.FHDJFAMMNOF:
				FHDJFAMMNOF = other.FHDJFAMMNOF;
				break;
			case FFGIEFNOLHNOneofCase.CGOABGKCBEF:
				CGOABGKCBEF = other.CGOABGKCBEF;
				break;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 88u:
				FHDJFAMMNOF = input.ReadUInt32();
				break;
			case 112u:
				CGOABGKCBEF = input.ReadUInt32();
				break;
			}
		}
	}
}
