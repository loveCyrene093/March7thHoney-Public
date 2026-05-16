using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JOAIMKBLHHD : IMessage<JOAIMKBLHHD>, IMessage, IEquatable<JOAIMKBLHHD>, IDeepCloneable<JOAIMKBLHHD>, IBufferMessage
{
	private static readonly MessageParser<JOAIMKBLHHD> _parser = new MessageParser<JOAIMKBLHHD>(() => new JOAIMKBLHHD());

	private UnknownFieldSet _unknownFields;

	public const int EPFDJFBCDILFieldNumber = 2;

	private bool ePFDJFBCDIL_;

	public const int GODGALFEHJFFieldNumber = 5;

	private bool gODGALFEHJF_;

	public const int HHKCADKCLJCFieldNumber = 7;

	private ulong hHKCADKCLJC_;

	public const int DOHLLMLDLMPFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_dOHLLMLDLMP_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> dOHLLMLDLMP_ = new RepeatedField<uint>();

	public const int GPJHJOOIJJCFieldNumber = 14;

	private uint gPJHJOOIJJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JOAIMKBLHHD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JOAIMKBLHHDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EPFDJFBCDIL
	{
		get
		{
			return ePFDJFBCDIL_;
		}
		set
		{
			ePFDJFBCDIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GODGALFEHJF
	{
		get
		{
			return gODGALFEHJF_;
		}
		set
		{
			gODGALFEHJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong HHKCADKCLJC
	{
		get
		{
			return hHKCADKCLJC_;
		}
		set
		{
			hHKCADKCLJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DOHLLMLDLMP => dOHLLMLDLMP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPJHJOOIJJC
	{
		get
		{
			return gPJHJOOIJJC_;
		}
		set
		{
			gPJHJOOIJJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOAIMKBLHHD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOAIMKBLHHD(JOAIMKBLHHD other)
		: this()
	{
		ePFDJFBCDIL_ = other.ePFDJFBCDIL_;
		gODGALFEHJF_ = other.gODGALFEHJF_;
		hHKCADKCLJC_ = other.hHKCADKCLJC_;
		dOHLLMLDLMP_ = other.dOHLLMLDLMP_.Clone();
		gPJHJOOIJJC_ = other.gPJHJOOIJJC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOAIMKBLHHD Clone()
	{
		return new JOAIMKBLHHD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JOAIMKBLHHD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JOAIMKBLHHD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EPFDJFBCDIL != other.EPFDJFBCDIL)
		{
			return false;
		}
		if (GODGALFEHJF != other.GODGALFEHJF)
		{
			return false;
		}
		if (HHKCADKCLJC != other.HHKCADKCLJC)
		{
			return false;
		}
		if (!dOHLLMLDLMP_.Equals(other.dOHLLMLDLMP_))
		{
			return false;
		}
		if (GPJHJOOIJJC != other.GPJHJOOIJJC)
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
		if (EPFDJFBCDIL)
		{
			num ^= EPFDJFBCDIL.GetHashCode();
		}
		if (GODGALFEHJF)
		{
			num ^= GODGALFEHJF.GetHashCode();
		}
		if (HHKCADKCLJC != 0L)
		{
			num ^= HHKCADKCLJC.GetHashCode();
		}
		num ^= dOHLLMLDLMP_.GetHashCode();
		if (GPJHJOOIJJC != 0)
		{
			num ^= GPJHJOOIJJC.GetHashCode();
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
		if (EPFDJFBCDIL)
		{
			output.WriteRawTag(16);
			output.WriteBool(EPFDJFBCDIL);
		}
		if (GODGALFEHJF)
		{
			output.WriteRawTag(40);
			output.WriteBool(GODGALFEHJF);
		}
		if (HHKCADKCLJC != 0L)
		{
			output.WriteRawTag(56);
			output.WriteUInt64(HHKCADKCLJC);
		}
		dOHLLMLDLMP_.WriteTo(ref output, _repeated_dOHLLMLDLMP_codec);
		if (GPJHJOOIJJC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GPJHJOOIJJC);
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
		if (EPFDJFBCDIL)
		{
			num += 2;
		}
		if (GODGALFEHJF)
		{
			num += 2;
		}
		if (HHKCADKCLJC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(HHKCADKCLJC);
		}
		num += dOHLLMLDLMP_.CalculateSize(_repeated_dOHLLMLDLMP_codec);
		if (GPJHJOOIJJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPJHJOOIJJC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JOAIMKBLHHD other)
	{
		if (other != null)
		{
			if (other.EPFDJFBCDIL)
			{
				EPFDJFBCDIL = other.EPFDJFBCDIL;
			}
			if (other.GODGALFEHJF)
			{
				GODGALFEHJF = other.GODGALFEHJF;
			}
			if (other.HHKCADKCLJC != 0L)
			{
				HHKCADKCLJC = other.HHKCADKCLJC;
			}
			dOHLLMLDLMP_.Add(other.dOHLLMLDLMP_);
			if (other.GPJHJOOIJJC != 0)
			{
				GPJHJOOIJJC = other.GPJHJOOIJJC;
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
			case 16u:
				EPFDJFBCDIL = input.ReadBool();
				break;
			case 40u:
				GODGALFEHJF = input.ReadBool();
				break;
			case 56u:
				HHKCADKCLJC = input.ReadUInt64();
				break;
			case 64u:
			case 66u:
				dOHLLMLDLMP_.AddEntriesFrom(ref input, _repeated_dOHLLMLDLMP_codec);
				break;
			case 112u:
				GPJHJOOIJJC = input.ReadUInt32();
				break;
			}
		}
	}
}
