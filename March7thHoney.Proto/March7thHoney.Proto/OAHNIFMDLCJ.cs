using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OAHNIFMDLCJ : IMessage<OAHNIFMDLCJ>, IMessage, IEquatable<OAHNIFMDLCJ>, IDeepCloneable<OAHNIFMDLCJ>, IBufferMessage
{
	private static readonly MessageParser<OAHNIFMDLCJ> _parser = new MessageParser<OAHNIFMDLCJ>(() => new OAHNIFMDLCJ());

	private UnknownFieldSet _unknownFields;

	public const int PFGLKFBHGKMFieldNumber = 2;

	private bool pFGLKFBHGKM_;

	public const int ILGIANHEALFFieldNumber = 8;

	private bool iLGIANHEALF_;

	public const int NGDKBDAMEHMFieldNumber = 14;

	private uint nGDKBDAMEHM_;

	public const int JOEBAPNOLAFFieldNumber = 15;

	private static readonly FieldCodec<ICOIMHLBMFI> _repeated_jOEBAPNOLAF_codec = FieldCodec.ForMessage(122u, ICOIMHLBMFI.Parser);

	private readonly RepeatedField<ICOIMHLBMFI> jOEBAPNOLAF_ = new RepeatedField<ICOIMHLBMFI>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OAHNIFMDLCJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OAHNIFMDLCJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PFGLKFBHGKM
	{
		get
		{
			return pFGLKFBHGKM_;
		}
		set
		{
			pFGLKFBHGKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ILGIANHEALF
	{
		get
		{
			return iLGIANHEALF_;
		}
		set
		{
			iLGIANHEALF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGDKBDAMEHM
	{
		get
		{
			return nGDKBDAMEHM_;
		}
		set
		{
			nGDKBDAMEHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ICOIMHLBMFI> JOEBAPNOLAF => jOEBAPNOLAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAHNIFMDLCJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAHNIFMDLCJ(OAHNIFMDLCJ other)
		: this()
	{
		pFGLKFBHGKM_ = other.pFGLKFBHGKM_;
		iLGIANHEALF_ = other.iLGIANHEALF_;
		nGDKBDAMEHM_ = other.nGDKBDAMEHM_;
		jOEBAPNOLAF_ = other.jOEBAPNOLAF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OAHNIFMDLCJ Clone()
	{
		return new OAHNIFMDLCJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OAHNIFMDLCJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OAHNIFMDLCJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PFGLKFBHGKM != other.PFGLKFBHGKM)
		{
			return false;
		}
		if (ILGIANHEALF != other.ILGIANHEALF)
		{
			return false;
		}
		if (NGDKBDAMEHM != other.NGDKBDAMEHM)
		{
			return false;
		}
		if (!jOEBAPNOLAF_.Equals(other.jOEBAPNOLAF_))
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
		if (PFGLKFBHGKM)
		{
			num ^= PFGLKFBHGKM.GetHashCode();
		}
		if (ILGIANHEALF)
		{
			num ^= ILGIANHEALF.GetHashCode();
		}
		if (NGDKBDAMEHM != 0)
		{
			num ^= NGDKBDAMEHM.GetHashCode();
		}
		num ^= jOEBAPNOLAF_.GetHashCode();
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
		if (PFGLKFBHGKM)
		{
			output.WriteRawTag(16);
			output.WriteBool(PFGLKFBHGKM);
		}
		if (ILGIANHEALF)
		{
			output.WriteRawTag(64);
			output.WriteBool(ILGIANHEALF);
		}
		if (NGDKBDAMEHM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(NGDKBDAMEHM);
		}
		jOEBAPNOLAF_.WriteTo(ref output, _repeated_jOEBAPNOLAF_codec);
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
		if (PFGLKFBHGKM)
		{
			num += 2;
		}
		if (ILGIANHEALF)
		{
			num += 2;
		}
		if (NGDKBDAMEHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGDKBDAMEHM);
		}
		num += jOEBAPNOLAF_.CalculateSize(_repeated_jOEBAPNOLAF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OAHNIFMDLCJ other)
	{
		if (other != null)
		{
			if (other.PFGLKFBHGKM)
			{
				PFGLKFBHGKM = other.PFGLKFBHGKM;
			}
			if (other.ILGIANHEALF)
			{
				ILGIANHEALF = other.ILGIANHEALF;
			}
			if (other.NGDKBDAMEHM != 0)
			{
				NGDKBDAMEHM = other.NGDKBDAMEHM;
			}
			jOEBAPNOLAF_.Add(other.jOEBAPNOLAF_);
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
				PFGLKFBHGKM = input.ReadBool();
				break;
			case 64u:
				ILGIANHEALF = input.ReadBool();
				break;
			case 112u:
				NGDKBDAMEHM = input.ReadUInt32();
				break;
			case 122u:
				jOEBAPNOLAF_.AddEntriesFrom(ref input, _repeated_jOEBAPNOLAF_codec);
				break;
			}
		}
	}
}
