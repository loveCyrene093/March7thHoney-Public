using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialPlayRoomPlayerMoveScNotify : IMessage<SocialPlayRoomPlayerMoveScNotify>, IMessage, IEquatable<SocialPlayRoomPlayerMoveScNotify>, IDeepCloneable<SocialPlayRoomPlayerMoveScNotify>, IBufferMessage
{
	private static readonly MessageParser<SocialPlayRoomPlayerMoveScNotify> _parser = new MessageParser<SocialPlayRoomPlayerMoveScNotify>(() => new SocialPlayRoomPlayerMoveScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MFBDMLPDEOEFieldNumber = 8;

	private uint mFBDMLPDEOE_;

	public const int FIPIDGKPFHAFieldNumber = 12;

	private CCKCCKHEFFB fIPIDGKPFHA_;

	public const int NCFHGIBCEBGFieldNumber = 13;

	private uint nCFHGIBCEBG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialPlayRoomPlayerMoveScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SocialPlayRoomPlayerMoveScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFBDMLPDEOE
	{
		get
		{
			return mFBDMLPDEOE_;
		}
		set
		{
			mFBDMLPDEOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCKCCKHEFFB FIPIDGKPFHA
	{
		get
		{
			return fIPIDGKPFHA_;
		}
		set
		{
			fIPIDGKPFHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCFHGIBCEBG
	{
		get
		{
			return nCFHGIBCEBG_;
		}
		set
		{
			nCFHGIBCEBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayRoomPlayerMoveScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayRoomPlayerMoveScNotify(SocialPlayRoomPlayerMoveScNotify other)
		: this()
	{
		mFBDMLPDEOE_ = other.mFBDMLPDEOE_;
		fIPIDGKPFHA_ = ((other.fIPIDGKPFHA_ != null) ? other.fIPIDGKPFHA_.Clone() : null);
		nCFHGIBCEBG_ = other.nCFHGIBCEBG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayRoomPlayerMoveScNotify Clone()
	{
		return new SocialPlayRoomPlayerMoveScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SocialPlayRoomPlayerMoveScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SocialPlayRoomPlayerMoveScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MFBDMLPDEOE != other.MFBDMLPDEOE)
		{
			return false;
		}
		if (!object.Equals(FIPIDGKPFHA, other.FIPIDGKPFHA))
		{
			return false;
		}
		if (NCFHGIBCEBG != other.NCFHGIBCEBG)
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
		if (MFBDMLPDEOE != 0)
		{
			num ^= MFBDMLPDEOE.GetHashCode();
		}
		if (fIPIDGKPFHA_ != null)
		{
			num ^= FIPIDGKPFHA.GetHashCode();
		}
		if (NCFHGIBCEBG != 0)
		{
			num ^= NCFHGIBCEBG.GetHashCode();
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
		if (MFBDMLPDEOE != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MFBDMLPDEOE);
		}
		if (fIPIDGKPFHA_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FIPIDGKPFHA);
		}
		if (NCFHGIBCEBG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(NCFHGIBCEBG);
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
		if (MFBDMLPDEOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFBDMLPDEOE);
		}
		if (fIPIDGKPFHA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FIPIDGKPFHA);
		}
		if (NCFHGIBCEBG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCFHGIBCEBG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SocialPlayRoomPlayerMoveScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MFBDMLPDEOE != 0)
		{
			MFBDMLPDEOE = other.MFBDMLPDEOE;
		}
		if (other.fIPIDGKPFHA_ != null)
		{
			if (fIPIDGKPFHA_ == null)
			{
				FIPIDGKPFHA = new CCKCCKHEFFB();
			}
			FIPIDGKPFHA.MergeFrom(other.FIPIDGKPFHA);
		}
		if (other.NCFHGIBCEBG != 0)
		{
			NCFHGIBCEBG = other.NCFHGIBCEBG;
		}
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
			case 64u:
				MFBDMLPDEOE = input.ReadUInt32();
				break;
			case 98u:
				if (fIPIDGKPFHA_ == null)
				{
					FIPIDGKPFHA = new CCKCCKHEFFB();
				}
				input.ReadMessage(FIPIDGKPFHA);
				break;
			case 104u:
				NCFHGIBCEBG = input.ReadUInt32();
				break;
			}
		}
	}
}
