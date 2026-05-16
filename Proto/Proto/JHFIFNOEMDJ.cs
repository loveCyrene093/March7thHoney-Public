using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JHFIFNOEMDJ : IMessage<JHFIFNOEMDJ>, IMessage, IEquatable<JHFIFNOEMDJ>, IDeepCloneable<JHFIFNOEMDJ>, IBufferMessage
{
	private static readonly MessageParser<JHFIFNOEMDJ> _parser = new MessageParser<JHFIFNOEMDJ>(() => new JHFIFNOEMDJ());

	private UnknownFieldSet _unknownFields;

	public const int EPNMKCAGLABFieldNumber = 2;

	private uint ePNMKCAGLAB_;

	public const int FLHLJMEMIHLFieldNumber = 7;

	private static readonly FieldCodec<BCICEMDDGEM> _repeated_fLHLJMEMIHL_codec = FieldCodec.ForMessage(58u, BCICEMDDGEM.Parser);

	private readonly RepeatedField<BCICEMDDGEM> fLHLJMEMIHL_ = new RepeatedField<BCICEMDDGEM>();

	public const int BKCMKIKBAEPFieldNumber = 9;

	private uint bKCMKIKBAEP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JHFIFNOEMDJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JHFIFNOEMDJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPNMKCAGLAB
	{
		get
		{
			return ePNMKCAGLAB_;
		}
		set
		{
			ePNMKCAGLAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BCICEMDDGEM> FLHLJMEMIHL => fLHLJMEMIHL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BKCMKIKBAEP
	{
		get
		{
			return bKCMKIKBAEP_;
		}
		set
		{
			bKCMKIKBAEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHFIFNOEMDJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHFIFNOEMDJ(JHFIFNOEMDJ other)
		: this()
	{
		ePNMKCAGLAB_ = other.ePNMKCAGLAB_;
		fLHLJMEMIHL_ = other.fLHLJMEMIHL_.Clone();
		bKCMKIKBAEP_ = other.bKCMKIKBAEP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHFIFNOEMDJ Clone()
	{
		return new JHFIFNOEMDJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JHFIFNOEMDJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JHFIFNOEMDJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EPNMKCAGLAB != other.EPNMKCAGLAB)
		{
			return false;
		}
		if (!fLHLJMEMIHL_.Equals(other.fLHLJMEMIHL_))
		{
			return false;
		}
		if (BKCMKIKBAEP != other.BKCMKIKBAEP)
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
		if (EPNMKCAGLAB != 0)
		{
			num ^= EPNMKCAGLAB.GetHashCode();
		}
		num ^= fLHLJMEMIHL_.GetHashCode();
		if (BKCMKIKBAEP != 0)
		{
			num ^= BKCMKIKBAEP.GetHashCode();
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
		if (EPNMKCAGLAB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EPNMKCAGLAB);
		}
		fLHLJMEMIHL_.WriteTo(ref output, _repeated_fLHLJMEMIHL_codec);
		if (BKCMKIKBAEP != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BKCMKIKBAEP);
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
		if (EPNMKCAGLAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPNMKCAGLAB);
		}
		num += fLHLJMEMIHL_.CalculateSize(_repeated_fLHLJMEMIHL_codec);
		if (BKCMKIKBAEP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BKCMKIKBAEP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JHFIFNOEMDJ other)
	{
		if (other != null)
		{
			if (other.EPNMKCAGLAB != 0)
			{
				EPNMKCAGLAB = other.EPNMKCAGLAB;
			}
			fLHLJMEMIHL_.Add(other.fLHLJMEMIHL_);
			if (other.BKCMKIKBAEP != 0)
			{
				BKCMKIKBAEP = other.BKCMKIKBAEP;
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
				EPNMKCAGLAB = input.ReadUInt32();
				break;
			case 58u:
				fLHLJMEMIHL_.AddEntriesFrom(ref input, _repeated_fLHLJMEMIHL_codec);
				break;
			case 72u:
				BKCMKIKBAEP = input.ReadUInt32();
				break;
			}
		}
	}
}
